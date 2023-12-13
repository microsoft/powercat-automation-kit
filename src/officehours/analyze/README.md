# Overview

This Python script uses the [akaze.py](./akaze.py) sample to create the [scan.py].

The process assumes the following:

1. You have an install of Python 3.7 of greater.
1. You have an installed local copy of Microsoft Power Point
1. You are running this process on a Windows environment

## Getting Started

1. Ensure that you have python installed. The [Beginners Guide](https://wiki.python.org/moin/BeginnersGuide/Download) provide a good starting point.

2. Installed dependencies

```cmd
pip install -r requirements.txt
```

3. Download meeting recording into this folder

4. Download of presentation used for the call into this folder

5. Scan the video for possible ClipChamp edit points.

```cmd
python scan.py
```

## How is this done?

One of the key elements of the this process is using the Python opencv and AKAZE algorithm together to scan frames of the video that match slides from the presentation to the meeting recording video.

OpenCV (Open Source Computer Vision) is a library of programming functions mainly aimed at real-time computer vision. It provides a set of tools and algorithms for processing and analyzing images and videos. OpenCV can be used for a variety of tasks, such as object detection, face recognition, motion tracking, and image stitching. It is open source, meaning that anyone can use and modify the code for their own purposes. In this project it is used to get frames from the video and detect frames within the Microsoft Teams recording.

AKAZE (Accelerated-KAZE) is a type of algorithm used for detecting and describing features in images. It works by analyzing the intensity and gradient of pixels in an image to find key points, which can then be used to compare images. AKAZE is helpful for comparing images because it can detect and match features even when the images are taken from different angles or have different lighting conditions. This makes it useful for tasks like object recognition, image stitching, and 3D reconstruction.

This combination is important in this analysis process as the frames of the presentation are embedded in the Microsoft Team video. By combining Microsoft Power Point, the video recording and the python modules together we have a simple way of detecting portions of the video that are related to the presentation and point out areas that could be candidates to review or edit out.
