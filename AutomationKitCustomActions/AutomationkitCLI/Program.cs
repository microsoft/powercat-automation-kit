using System;
using System.Diagnostics;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using AutomationkitCLI;

static void Main()
{
    Console.WriteLine("Enter a name for the certificate:");
    string certificateName = Console.ReadLine();

    Console.WriteLine("Enter the password for the certificate:");
    SecureString password = GetSecurePassword();

    // Create the certificate
    string thumbprint = ActionsHelper.CreateCertificate(certificateName, password);

    Console.WriteLine($"Certificate created. Thumbprint: {thumbprint}");

    // Import the certificate to trust root
    X509Certificate2 certificate = new X509Certificate2("AutomationKitCACert.pfx", password, X509KeyStorageFlags.Exportable);
    ActionsHelper.ImportCertificateToTrustRoot(certificate);

    Console.WriteLine("Certificate imported to trust root.");

    // Sign the DLL
    Console.WriteLine("Enter the path to signtool.exe:");
    string signtoolPath = Console.ReadLine();
    Console.WriteLine("Enter the path to the DLL:");
    string dllFilePath = Console.ReadLine();
    Console.WriteLine("Enter the path to the certificate:");
    string certificateFilePath = Console.ReadLine();
    Console.WriteLine("Enter the password for the certificate:");
    string certificatePassword = Console.ReadLine();
    Console.WriteLine("Signing the DLL...");
    SignDllWithSigntool(signtoolPath, dllFilePath, certificateFilePath, certificatePassword);

    // Package the DLL to a CAB file
    Console.WriteLine("Enter the path to makecab.exe:");
    string makecabPath = Console.ReadLine();
    Console.WriteLine("Enter the path to the DLL:");
    string dllPath = Console.ReadLine();
    Console.WriteLine("Enter the path to the dependencies directory:");
    string dependenciesDirectory = Console.ReadLine();
    Console.WriteLine("Enter the path to the output directory:");
    string outputDirectory = Console.ReadLine();
    Console.WriteLine("Packaging the DLL...");
    PackageDllToCab(makecabPath, dllPath, dependenciesDirectory, outputDirectory);
    Console.WriteLine("DLL packaging completed successfully.");
   


}

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


