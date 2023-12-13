import cv2
import numpy as np
import os
from pptx import Presentation
from win32com import client
import time
import glob
import pathlib

def decimal_seconds_to_time(decimal_seconds):
    # Calculate hours, minutes, and seconds
    total_seconds = int(decimal_seconds)
    hours = total_seconds // 3600
    minutes = (total_seconds % 3600) // 60
    seconds = total_seconds % 60
    
    # Calculate fractional seconds
    fractional_seconds = decimal_seconds - total_seconds
    fractional_seconds = f"{fractional_seconds:.2f}"
    
    # Format the time as hh:mm:ss.ff
    time_str = f"{hours:02d}:{minutes:02d}:{seconds:02d}.{fractional_seconds[-2:]}"
    
    return time_str

def append_cut_time(filename, time):
    with open(filename, "a") as myfile:
        myfile.write(decimal_seconds_to_time(time) + "\n")

def export_slides(pptx_path):
    print('Exporting slides')
    # Extract slides from the PowerPoint presentation and save them as PNG files
    # presentation = Presentation(pptx_path)

    # Create a PDF with section information using PowerPoint.Application
    ppt_app = client.Dispatch("PowerPoint.Application")

    presentation_path = os.path.abspath(pptx_path)
    presentation = ppt_app.Presentations.Open(presentation_path)
    presentation.SaveAs(os.path.abspath("output_png_files"), 18)  # ppSaveAsPNG
    #presentation.Close()
    print('Export complete')

# Path to the video file and PPTX file (Assumes that only one of each type)
video_path = glob.glob('*.mp4')[0]
pptx_path = glob.glob('*.pptx')[0]
output_directory = "output_png_files"

# Create the output directory if it doesn't exist
os.makedirs(output_directory, exist_ok=True)

# Open the video file
cap = cv2.VideoCapture(video_path)
frame_number = 0
fps = int(cap.get(cv2.CAP_PROP_FPS))

# Calculate the target frame interval for messages (10 seconds)
target_frame_interval = int(fps * 10)

slidesImages = os.path.join("output_directory","*.PNG")

if not os.path.isdir(output_directory ):
    os.mkdir(output_directory)

if len(glob.glob(slidesImages)) == 0:
    export_slides(pptx_path)

non_matching_frame_start = None
start_time = time.time()
target_frame = target_frame_interval  # Initialize the target frame
last_frame = None
threshold = 50

fs = cv2.FileStorage(cv2.samples.findFile('H1to3p.xml'), cv2.FILE_STORAGE_READ)
homography = fs.getFirstTopLevelNode().mat()
akaze = cv2.AKAZE_create()

first_match = True
matches = 0
last_match = None

editPath=os.path.join(pathlib.Path(__file__).parent.resolve(),"..", "edit")

if not os.path.isdir(editPath):
    os.makedirs(editPath)

cutTimesFile=os.path.join(editPath, "times.txt")
if os.path.isfile(cutTimesFile):
  os.remove(cutTimesFile)

print('Scanning video')

while True:
    ret, frame = cap.read()
    if not ret:
        break

    frame_number += 1

    gray = cv2.cvtColor(frame, cv2.COLOR_BGR2GRAY)

    if last_frame is None:
        last_frame = gray

    if last_frame.shape == gray.shape:
        #--- take the absolute difference of the images ---
        res = cv2.absdiff(gray, last_frame)

        #--- convert the result to integer type ---
        res = res.astype(np.uint8)

        #--- find percentage difference based on number of pixels that are not zero ---
        percentage_difference = (np.count_nonzero(res) * 100)/ res.size

        if percentage_difference > threshold:
            timecode = frame_number / fps    
            #print(f"Found {percentage_difference} difference at {timecode:.2f} seconds")
            cv2.imwrite(os.path.join("frames",f"{frame_number}.png"), frame)

            # Compare the current frame with each PNG file (slides)
            frame_matched = False
            for filename in os.listdir(output_directory):
                if filename.endswith(".PNG"):
                    template = cv2.imread(os.path.join(output_directory, filename), cv2.IMREAD_GRAYSCALE)
                    
                    # You can adjust this threshold as needed
                    kpts1, desc1 = akaze.detectAndCompute(gray, None)
                    kpts2, desc2 = akaze.detectAndCompute(template, None)
                    matcher = cv2.DescriptorMatcher_create(cv2.DescriptorMatcher_BRUTEFORCE_HAMMING)
                    nn_matches = matcher.knnMatch(desc1, desc2, 2)
                    matched1 = []
                    matched2 = []
                    nn_match_ratio = 0.8 # Nearest neighbor matching ratio
                    for m, n in nn_matches:
                        if m.distance < nn_match_ratio * n.distance:
                            matched1.append(kpts1[m.queryIdx])
                            matched2.append(kpts2[m.trainIdx])
                    if ( len(matched1) > 250 ):
                        if ( first_match ):
                            append_cut_time(cutTimesFile, frame_number / fps)
                            matches = matches + 1
                            last_match = frame_number
                            print(f'Match {filename}')
                            first_match = False
                        frame_matched = True
                        break

            if not frame_matched:
                if non_matching_frame_start is None:
                    if ( matches > 0 and frame_number != last_match):
                        matches = matches + 1
                        last_match = frame_number
                        append_cut_time(cutTimesFile, frame_number / fps)
                    non_matching_frame_start = frame_number

            elif non_matching_frame_start is not None:
                if ( matches > 0 and frame_number != last_match):
                    matches = matches + 1
                    last_match = frame_number
                    append_cut_time(cutTimesFile, frame_number / fps)
                non_matching_frame_end = frame_number - 1
                timecode_start = non_matching_frame_start / fps
                timecode_end = non_matching_frame_end / fps
                print(f"Non-matching frames from {timecode_start:.2f} to {timecode_end:.2f} seconds")
                non_matching_frame_start = None
        
    # Print a message every 10 seconds
    if frame_number >= target_frame:
        elapsed_time = time.time() - start_time
        print(f"Processing video at {frame_number / fps:.2f} seconds")
        target_frame += target_frame_interval
        start_time = time.time()
    
    last_frame = gray

if non_matching_frame_start is not None:
    timecode_start = non_matching_frame_start / fps
    print(f"Non-matching frames from {timecode_start:.2f} seconds")

print(f"Found {matches} cuts that could be made that have been added to {cutTimesFile}")

# Release the video capture object
cap.release()

print('Complete')
