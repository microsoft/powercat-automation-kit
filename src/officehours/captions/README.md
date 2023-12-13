# Overview

This Python script uses modules to trim the Teams Audio Transcript to the produced video from Clipchamp

The process assumes the following:

1. You have an install of Python 3.7 of greater.

## Getting Started

1. Ensure that you have python installed. The [Beginners Guide](https://wiki.python.org/moin/BeginnersGuide/Download) provide a good starting point.

2. Installed dependencies

```cmd
pip install -r requirements.txt
```

3. Download the transcript from the Teams call to this folder (*.vtt)

4. Download the Clipchamp project file to this folder from your SharePoint Business folder (*.clipchamp)

5. Generate the trimmed caption file

```cmd
python trim.py
```
