# Overview

The edit stage automate the initial editing of an analyzed video using Microsoft SharePoint integrated Clipchamp.

Assumptions for this process:

1. Edge is installed as a browser
2. .Net 7.0 SDK is installed. I it is not installed refer to [Download .Net 7.0](https://dotnet.microsoft.com/en-us/download/dotnet/7.0)

## Getting Started

1. Build the solutions

```powershell
cd edit
dotnet build
```

2. Install Playwright (Only needs to be run once)

```powershell
Push-Location
cd bin\Debug\net7.0
.\playwright
Pop-Location
```

3. Run the app

```powershell
dotnet run
```
