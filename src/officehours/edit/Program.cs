using System.Globalization;
using Microsoft.Playwright;
using System.IO;
using System.Linq;

using var playwright = await Playwright.CreateAsync();
var context = string.Format(@"C:\Users\{0}\AppData\Local\Microsoft\Edge\User Data\Default", Environment.UserName);
await using var browser = await playwright.Chromium.LaunchPersistentContextAsync(context, new BrowserTypeLaunchPersistentContextOptions {
    Channel = "msedge", 
    Headless = false
});

var page = await browser.NewPageAsync();
await OpenNewClipChampProject(page);

IPage clipChamp = null;

clipChamp = await GetClipChampChampPage(page);

string assemblyFolder = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
var analyzeFolder = Path.Combine(assemblyFolder, "..", "..", "..", "..", "analyze");
var videoName = Directory.GetFiles(analyzeFolder, "*.mp4").FirstOrDefault();

if ( clipChamp != null ) {
    await RenameVideo(clipChamp, "Sample " + DateTime.Now.ToString("yyyy-MM-dd HH-mm"));
   
    await UploadAndAddVideo(clipChamp, videoName, analyzeFolder);

    var editFolder = Path.Combine(assemblyFolder, "..", "..", "..");
    var timesFile = Path.Combine(editFolder,"times.txt");

    var times = File.ReadAllLines(timesFile);

    await CropVideo(clipChamp, videoName, times.FirstOrDefault());

    // To review moving to changing the clipchamp json file to add edits
    // 
    // if ( File.Exists(timesFile)) {
    //     foreach ( var line in File.ReadAllLines(timesFile)) {
    //         if ( ! String.IsNullOrEmpty(line) ) {
    //             await SplitAtTime(clipChamp, videoName, line);
    //         }
    //     }
    // }

    Console.WriteLine("Edits made review changes, remove sections not needed and export video.");
    Console.WriteLine(page.Url);
    await clipChamp.PauseAsync();
}

async Task OpenNewClipChampProject(IPage page) {
    Console.WriteLine("Create Clipchamp project");

    await page.GotoAsync("https://microsoft365.com/launch/onedrive");
    await page.GetByRole(AriaRole.Menuitem, new() { Name = "Add new" }).ClickAsync();

    await page.RunAndWaitForPopupAsync(async () =>
    {
        await page.GetByRole(AriaRole.Menuitem, new() { Name = "Clipchamp video" }).ClickAsync();
    });
}

async Task UploadAndAddVideo(IPage page, string name, string path) {
    Console.WriteLine("Upload video");

    var fileChooser = await clipChamp.RunAndWaitForFileChooserAsync(async () =>
    {
        await clipChamp.ClickAsync("[data-testid='add-media']");
    });

    var file = name;
    if ( ! System.IO.Path.IsPathRooted(file) ) {
        file = Path.GetFullPath(Path.Combine(path, name));
    }
    
    await fileChooser.SetFilesAsync(file);
    
    await clipChamp.ClickAsync("[data-testid='add-asset-button']");
}

async Task RenameVideo(IPage page, string uniqueName) {
    Console.WriteLine("Rename video");

    await page.ClickAsync("[data-unique-id='DocumentTitleButton']");

    await page.GetByLabel("File name").ClickAsync();

    await page.GetByLabel("File name").FillAsync(uniqueName);

    await page.GetByLabel("File name").PressAsync("Tab");

    await page.ClickAsync("[data-unique-id='DocumentTitleButton']");
}


async Task<IPage?> GetClipChampChampPage(IPage page) {
    var started = DateTime.Now;
    var canExit = false;
    while ( !canExit ) {
        foreach ( var contextPage in page.Context.Pages ) {
            if ( await contextPage.IsVisibleAsync("[data-unique-id='DocumentTitleButton']") ) {
                return contextPage;
            }
        }
        Thread.Sleep(1000);
        if ( DateTime.Now.Subtract(started).Minutes > 1 ) {
            Console.WriteLine("Timeout waiting for clip champ page");
            break;
        }
    }

    if ( clipChamp == null ) {
        Console.Error.WriteLine("Unable to find clip champ");
    }

    return null;
}

async Task CropVideo(IPage page, string videoName, string? timeIndex) {
    if ( !String.IsNullOrEmpty(timeIndex) ) {
        await SelectTime(page, videoName, timeIndex);
    } else {
        await page.GetByLabel($"Trim forward button").ClickAsync();
    }
    
    await page.GetByLabel("Crop").ClickAsync();
    await page.GetByTestId("freehand-svg-container").ClickAsync();

    Console.WriteLine("Crop the video to remove portions of the screen you do not need");
    Console.WriteLine("Once crop is completed, press PLAY in Playwright and crop and fill be done automatically");

    await clipChamp.PauseAsync();
    await page.GetByLabel("Done").ClickAsync();
    await page.GetByLabel("Fill").ClickAsync();
}

async Task SelectTime(IPage page, string videoName, string timeIndex) {
    var time = DateTime.ParseExact(timeIndex, "hh:mm:ss.ff", CultureInfo.InvariantCulture);

    await page.GetByLabel("Player time input").ClickAsync();

    await page.GetByLabel("Minutes").FillAsync((time.Hour * 60 + time.Minute).ToString("#00"));

    await page.GetByLabel("Seconds", new() { Exact = true }).FillAsync(time.Second.ToString("00"));

    double value = int.Parse((1000 + time.Millisecond).ToString("0000").Substring(1)) / 100.0;

    await page.GetByLabel("Milliseconds").FillAsync(Math.Round(value,0).ToString("00"));

    await page.GetByLabel("Seconds", new() { Exact = true }).PressAsync("Enter");

    Console.WriteLine("Waiting to select time");

    System.Threading.Thread.Sleep(1000);

    //await page.GetByLabel($"Trim forward button").ClickAsync();
}

async Task SplitAtTime(IPage page, string videoName, string timeIndex) {
    await SelectTime(page, videoName, timeIndex);
    
    await clipChamp.GetByLabel("Trim forward button").PressAsync("s");
}