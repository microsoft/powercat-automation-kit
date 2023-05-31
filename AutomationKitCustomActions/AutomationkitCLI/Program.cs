using System;
using System.CommandLine;
using System.Diagnostics;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using AutomationkitCLI;

//#region CLI
//var rootCommand = new RootCommand("Automation kit Custom Actions CLI");


//rootCommand.Description = @"                                               
//                        Automation kit Custom Actions CLI

//The CLI command-line tool can be used to Create certificate, Import Certificate to Trusted root, Sign the Dll, Package into cab, sign can and deploy Custom Actions.

//Author:
//Power CAT
//Disclaimer:
//This command-line tool is unsupported, experimental, NOT an official Microsoft product and is provided 'as is' without support and warranty of any kind, either express or implied, including but not limited to warranties of merchantability, fitness for a particular purpose, and non-infringement. In no event shall the authors or copyright holders be liable for any claims, damages or other liabilities, whether in contract, tort or otherwise, arising out of, arising out of or in connection with the Software or the use or other dealings with the Software.";
//#region Create and Import Certificate
//var certificateName = new Option<string>(
//    "--certificateName",
//    description: "Certificate name for code signing");

//var password = new Option<SecureString>(
//    "--password",
//    description: "Password of the certificate");
//var eFgcolorOption = new Option<ConsoleColor>(
//    name: "--fgcolor",
//    description: "Foreground color of text displayed on the console.",
//    getDefaultValue: () => ConsoleColor.Cyan);
//var bLightModeOption = new Option<bool>(
//    name: "--light-mode",
//    description: "Background color of text displayed on the console: default is black, light mode is white.");
//certificateName.AddAlias("-name");
//certificateName.Arity = ArgumentArity.ExactlyOne;
//certificateName.IsRequired = true;

//password.AddAlias("-password");
//password.Arity = ArgumentArity.ExactlyOne;
//password.IsRequired = true;


//var createCertificate = new Command("Create-certificate", "certificatename") {
//    certificateName,
//    password,
//    eFgcolorOption,
//    bLightModeOption
//};

//createCertificate.Description = @"This command to create a certificate for code signing";

//createCertificate.SetHandler((string certname, SecureString pwd,  ConsoleColor fgColor, bool lightMode) =>
//{
//    Console.BackgroundColor = lightMode ? ConsoleColor.White : ConsoleColor.Black;
//    Console.ForegroundColor = fgColor;

//    // Create the certificate
//    X509Certificate2 certificate = ActionsHelper.CreateCertificate(certname, pwd);

//}, certificateName,
//    password,
//  eFgcolorOption,
//    bLightModeOption);

//rootCommand.AddCommand(createCertificate);

//#endregion

//return rootCommand.Invoke(args);
//#endregion
Console.WriteLine("*********** Create Certificate ***********************************");
Console.WriteLine("Enter a name for the certificate:");
string certificateName = Console.ReadLine();

Console.WriteLine("Enter the password for the certificate:");
SecureString password = GetSecurePassword();

// Create the certificate
X509Certificate2 certificate = ActionsHelper.CreateCertificate(certificateName, password);

Console.WriteLine($"Certificate created. Thumbprint: {certificate.Thumbprint}");

Console.WriteLine("*********** Import Certificate ***********************************");

Console.WriteLine($"Do you want to import certificate ? Y/N");
if (Console.ReadLine().ToUpper() == "Y")
{

    // Import the certificate to trust root
    //X509Certificate2 certificate = new X509Certificate2("AutomationKitCACert.pfx", password, X509KeyStorageFlags.Exportable);
    ActionsHelper.ImportCertificateToTrustRoot(certificate);

    Console.WriteLine("Certificate imported to trust root.");
}
Console.WriteLine("*********** Sign the dll ***********************************");
// Sign the DLL
Console.WriteLine("Enter the path to signtool.exe: C:\\Program Files (x86)\\Microsoft Visual Studio\\Shared\\NuGetPackages\\microsoft.windows.sdk.buildtools\\10.0.22621.756\\bin\\10.0.22621.0\\arm64");
string? signtoolPath = Console.ReadLine();
Console.WriteLine("Enter the path to the DLL:");
string? dllFilePath = Console.ReadLine();
Console.WriteLine("Enter the path to the certificate:");
string? certificateFilePath = Console.ReadLine();
Console.WriteLine("Enter the password for the certificate:");
string? certificatePassword = Console.ReadLine();
Console.WriteLine("Signing the DLL...");
SignDllWithSigntool(signtoolPath, dllFilePath, certificateFilePath, certificatePassword);
Console.WriteLine("Signing the DLL completed...");


Console.WriteLine("*********** Package the DLL to a CAB file ***********************************");
// Package the DLL to a CAB file
Console.WriteLine("Enter the path to makecab.exe:");
string makecabPath = Console.ReadLine();
Console.WriteLine("Enter the path to the Custom Action dll:");
string dllPath = Console.ReadLine();
Console.WriteLine("Enter the path to the dependencies directory:");
string dependenciesDirectory = Console.ReadLine();
Console.WriteLine("Enter the path to the output directory:");
string outputDirectory = Console.ReadLine();
Console.WriteLine("Packaging the DLL...");
PackageDllToCab(makecabPath, dllPath, dependenciesDirectory, outputDirectory);
Console.WriteLine("DLL packaging completed successfully.");


//Sign the cab
Console.WriteLine("*********** Sign the cab ***********************************");

Console.WriteLine("Enter the path to the cab:");
string? cabFilePath = Console.ReadLine();
Console.WriteLine("Signing the cab...");
SignDllWithSigntool(signtoolPath, cabFilePath, certificateFilePath, certificatePassword);
Console.WriteLine("Signing the cab completed...");


Console.WriteLine("*********** Login to Dataverse ***********************************");

Console.WriteLine("Enter the Dataverse URL:");
string? dataverseUrl = Console.ReadLine();
Console.WriteLine("Enter the Dataverse username:");
string? dataverseUsername = Console.ReadLine();
DataverseHelper.ConnectToDataverse(dataverseUrl, dataverseUsername);

Console.WriteLine("*********** Upload Custom Actions ***********************************");



static SecureString GetSecurePassword()
{
    SecureString securePassword = new SecureString();

    ConsoleKeyInfo key;
    do
    {
        key = Console.ReadKey(true);
        if (key.Key != ConsoleKey.Enter)
        {
            securePassword.AppendChar(key.KeyChar);
        }
    } while (key.Key != ConsoleKey.Enter);

    return securePassword;
}

static void SignDllWithSigntool(string signtoolPath, string dllFilePath, string certificateFilePath, string certificatePassword)
{
    try
    {
        // Construct the signtool command
        string arguments = $@"sign /f ""{certificateFilePath}"" /p ""{certificatePassword}"" ""{dllFilePath}""";

        // Create a process start info for signtool
        ProcessStartInfo startInfo = new ProcessStartInfo
        {
            FileName = signtoolPath,
            Arguments = arguments,
            UseShellExecute = false,
            CreateNoWindow = true
        };

        // Execute signtool
        using (Process process = Process.Start(startInfo))
        {
            process.WaitForExit();

            if (process.ExitCode == 0)
            {
                Console.WriteLine("DLL signing completed successfully.");
            }
            else
            {
                Console.WriteLine("Failed to sign the DLL.");
            }
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error occurred while signing the DLL: {ex.Message}");
    }

}
/// <summary>   
/// makecab.exe is a command line tool that can be used to create cabinet (.cab) files. 
/// makecabPath: The file path to the makecab.exe tool.
/// dllFilePath: The path to the main DLL file containing custom actions.
/// dependenciesDirectory: The directory containing the dependency DLL files.
/// cabFilePath: The path to the output CAB file.
/// </summary>  
static void PackageDllToCab(string makecabPath, string dllFilePath, string dependenciesDirectory, string cabFilePath)
{
    try
    {
        // Create a temporary directory for the CAB file
        string tempDirectory = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
        Directory.CreateDirectory(tempDirectory);

        // Copy the DLL file and dependencies to the temporary directory
        string tempDllFilePath = Path.Combine(tempDirectory, Path.GetFileName(dllFilePath));
        File.Copy(dllFilePath, tempDllFilePath, true);

        string[] dependencyFiles = Directory.GetFiles(dependenciesDirectory, "*.dll");
        foreach (string dependencyFilePath in dependencyFiles)
        {
            string tempDependencyFilePath = Path.Combine(tempDirectory, Path.GetFileName(dependencyFilePath));
            File.Copy(dependencyFilePath, tempDependencyFilePath, true);
        }

        // Construct the makecab command
        string arguments = $@"{tempDirectory}\*.* ""{cabFilePath}""";

        // Create a process start info for makecab
        ProcessStartInfo startInfo = new ProcessStartInfo
        {
            FileName = makecabPath,
            Arguments = arguments,
            UseShellExecute = false,
            CreateNoWindow = true
        };

        // Execute makecab
        using (Process process = Process.Start(startInfo))
        {
            process.WaitForExit();

            if (process.ExitCode == 0)
            {
                Console.WriteLine("Cabinet file creation completed successfully.");
            }
            else
            {
                Console.WriteLine("Failed to create the cabinet file.");
            }
        }

        // Clean up the temporary directory
        Directory.Delete(tempDirectory, true);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error occurred while creating the cabinet file: {ex.Message}");
    }
}

