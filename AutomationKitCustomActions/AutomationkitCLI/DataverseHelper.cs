using Microsoft.PowerPlatform.Dataverse.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationkitCLI
{
    internal static class DataverseHelper
    {
        internal static ServiceClient ConnectToDataverse(string username, string Envinstanceurl, bool clearScreen = true)
        {
            ServiceClient? service = null;

            try
            {
                Console.WriteLine($"Connecting to {Envinstanceurl}... Please Check your Web Browser to login.");

                StringBuilder connectionString = new StringBuilder();

                connectionString.Append("AuthType=OAuth;");
                connectionString.Append($"Username={username};");
                connectionString.Append($"Integrated Security=true;");
                connectionString.Append($"Url={Envinstanceurl};");
                connectionString.Append($"AppId=51f81489-12ee-4a9e-aaae-a2591f45987d;");// Standard App Id available globally
                connectionString.Append($"RedirectUri=http://localhost;");
                connectionString.Append($"LoginPrompt=Auto");                           // Promt for interactive Login

                // Try to create via connection string. 
                service = new ServiceClient(connectionString.ToString());

                if (service.IsReady)
                {
                    if (clearScreen) Console.Clear();
                    Console.WriteLine($"\n...successfully connected to {service.ConnectedOrgFriendlyName}!\n");
                }
                else
                {
                    const string UNABLE_TO_LOGIN_ERROR = "Unable to Login to Microsoft Dataverse";
                    if (service.LastError.Equals(UNABLE_TO_LOGIN_ERROR))
                    {
                        Console.WriteLine("Check the connection string values passed in to the application.");
                        throw new Exception(service.LastError);
                    }
                    else
                    {
                        throw service.LastException;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return service;
        }

    }
}
