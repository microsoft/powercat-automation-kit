from vtt_to_srt.vtt_to_srt import ConvertFile
import os
import pysrt
import glob

for f in glob.glob("*.srt"):
    os.remove(f)

transcriptFile = glob.glob('*.vtt')[0]

convert_file = ConvertFile(transcriptFile, "utf-8")
convert_file.convert()

source = glob.glob('*.srt')[0]

with open(source, 'r') as input_file, open('new.srt', 'w') as output_file:
    for line in input_file:
        if '/' in line and '-' in line:
            continue
        output_file.write(line)

subs = pysrt.open('new.srt')

import json
# Trim a captions file srt to the times of the video trim times
# Cases to handle:
# - Trimmed start
# - Trimmed end

remove_start = 0
with open(glob.glob('*.clipchamp')[0]) as f:
    data = json.load(f)
    for id in data['items']['allIds']:
        start = data['items']['byId'][id]['startTime']
       
        trim_start = data['items']['byId'][id]['trim']['from']
        trim_end = data['items']['byId'][id]['trim']['to']
        if ( start == 0 ):
            remove_start = trim_start
        print(f"{start} ({trim_start} - {trim_end})")

if remove_start > 0:
    subs.shift(seconds=(-1 * remove_start))

subs.save('captions.srt', encoding='utf-8')