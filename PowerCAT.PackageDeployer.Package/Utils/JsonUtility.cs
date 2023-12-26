using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.Json;

/// <summary>
/// Utility class for working with JSON data.
/// </summary>
public class JsonUtility
{

    private static Dictionary<string, string> jsonCache = new Dictionary<string, string>();

    /// <summary>
    /// Reads the PreDeploymentSettings from the specified JSON file for a given project name.
    /// </summary>
    /// <param name="filePathOrUrl">The path to the JSON file.</param>
    /// <param name="projectName">The name of the project to retrieve PreDeploymentSettings for.</param>
    /// <returns>A dictionary containing the PreDeploymentSettings, or null if the project or settings are not found.</returns>
    public static Dictionary<string, string> ReadPreDeploymentSettings(string filePathOrUrl, string projectName)
    {
        try
        {
            // Read the entire file content from either local path or URL
            string jsonContent = ReadJsonContent(filePathOrUrl);

            // Parse the JSON data
            JsonDocument jsonDocument = JsonDocument.Parse(jsonContent);

            // Find the Project node with the specified name
            JsonElement projectNode = FindProjectNode(jsonDocument.RootElement.GetProperty("Project"), projectName);

            if (projectNode.ValueKind != JsonValueKind.Null)
            {
                // Extract PreDeploymentSettings into a dictionary
                return ExtractSettings(projectNode, "PreDeploymentSettings");
            }

            return null;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading or processing JSON data: {ex.Message}");
            return null;
        }
    }

    /// <summary>
    /// Reads the PostDeploymentSettings from the specified JSON file for a given project name.
    /// </summary>
    /// <param name="filePathOrUrl">The path to the JSON file.</param>
    /// <param name="projectName">The name of the project to retrieve PostDeploymentSettings for.</param>
    /// <returns>A dictionary containing the PostDeploymentSettings, or null if the project or settings are not found.</returns>
    public static Dictionary<string, string> ReadPostDeploymentSettings(string filePathOrUrl, string projectName)
    {
        try
        {
            // Read the entire file content from either local path or URL
            string jsonContent = ReadJsonContent(filePathOrUrl);

            // Parse the JSON data
            JsonDocument jsonDocument = JsonDocument.Parse(jsonContent);

            // Find the Project node with the specified name
            JsonElement projectNode = FindProjectNode(jsonDocument.RootElement.GetProperty("Project"), projectName);

            if (projectNode.ValueKind != JsonValueKind.Null)
            {
                // Extract PostDeploymentSettings into a dictionary
                return ExtractSettings(projectNode, "PostDeploymentSettings");
            }

            return null;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading or processing JSON data: {ex.Message}");
            return null;
        }
    }

    /// <summary>
    /// Reads the list of package names from the specified JSON file or URL for a given project name.
    /// </summary>
    /// <param name="filePathOrUrl">The path to the JSON file or a publicly accessible URL.</param>
    /// <param name="projectName">The name of the project to retrieve package names for.</param>
    /// <returns>A list containing the package names, or an empty list if the project or 'Packages' node is not found or is not an array.</returns>
    public static List<string> ReadPackages(string filePathOrUrl, string projectName)
    {
        try
        {
            // Read the entire file content from either local path or URL
            string jsonContent = ReadJsonContent(filePathOrUrl);

            if (jsonContent == null)
            {
                Console.WriteLine("Error reading JSON content.");
                return new List<string>();
            }

            // Parse the JSON data
            JsonDocument jsonDocument = JsonDocument.Parse(jsonContent);

            // Find the Project node with the specified name
            JsonElement projectNode = FindProjectNode(jsonDocument.RootElement.GetProperty("Project"), projectName);

            // Check if the Project node exists and contains the 'Packages' property
            if (projectNode.ValueKind != JsonValueKind.Null)
            {
                JsonElement packagesElement;

                // Check if the 'Packages' property exists
                if (projectNode.TryGetProperty("Packages", out packagesElement) && packagesElement.ValueKind == JsonValueKind.Array)
                {
                    // Retrieve package names
                    return packagesElement.EnumerateArray().Select(package => package.GetString()).ToList();
                }
                else
                {
                    Console.WriteLine("Packages property not found or is not an array.");
                }
            }
            else
            {
                Console.WriteLine($"Project with name '{projectName}' not found.");
            }

            // Return an empty list if the project or 'Packages' node is not found or is not an array
            return new List<string>();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading or processing JSON data: {ex.Message}");
            return null;
        }
    }

    /// <summary>
    /// Reads the 'environmentid' from the specified JSON file for a given project name.
    /// </summary>
    /// <param name="filePathOrUrl">The path to the JSON file.</param>
    /// <param name="projectName">The name of the project to retrieve 'environmentid' for.</param>
    /// <returns>The 'environmentid' string, or null if the project or 'environmentid' is not found.</returns>
    public static string ReadEnvironmentId(string filePathOrUrl, string projectName)
    {
        try
        {
            // Read the entire file content from either local path or URL
            string jsonContent = ReadJsonContent(filePathOrUrl);

            // Parse the JSON data
            JsonDocument jsonDocument = JsonDocument.Parse(jsonContent);

            // Find the Project node with the specified name
            JsonElement projectNode = FindProjectNode(jsonDocument.RootElement.GetProperty("Project"), projectName);

            // Check if the Project node exists and contains the 'environmentid' property
            if (projectNode.ValueKind != JsonValueKind.Null && projectNode.TryGetProperty("environmentid", out JsonElement environmentIdElement))
            {
                return environmentIdElement.GetString();
            }

            // Return null if the project or 'environmentid' is not found
            return null;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading or processing JSON data: {ex.Message}");
            return null;
        }
    }

    /// <summary>
    /// Finds the Project node with the specified name.
    /// </summary>
    /// <param name="projectsNode">The JSON node containing the list of projects.</param>
    /// <param name="projectName">The name of the project to find.</param>
    /// <returns>The Project node if found, or Null if not found.</returns>
    private static JsonElement FindProjectNode(JsonElement projectsNode, string projectName)
    {
        foreach (JsonElement projectNode in projectsNode.EnumerateArray())
        {
            if (projectNode.GetProperty("name").GetString() == projectName)
            {
                return projectNode;
            }
        }

        // Return Null if not found
        return default;
    }

    /// <summary>
    /// Extracts the specified settings type from the Project node into a dictionary.
    /// </summary>
    /// <param name="projectNode">The Project node containing settings.</param>
    /// <param name="settingsType">The type of settings to extract (e.g., PreDeploymentSettings).</param>
    /// <returns>A dictionary containing the extracted settings.</returns>
    private static Dictionary<string, string> ExtractSettings(JsonElement projectNode, string settingsType)
    {
        var settings = new Dictionary<string, string>();

        // Check if the specified settings type exists
        if (projectNode.TryGetProperty(settingsType, out JsonElement settingsNode))
        {
            foreach (JsonElement settingNode in settingsNode.EnumerateArray())
            {
                string settingName = settingNode.GetProperty("settingname").GetString();
                string settingValue = settingNode.GetProperty("value").GetString();
                settings.Add(settingName, settingValue);
            }
        }

        return settings;
    }

    /// <summary>
    /// Helper function to check if a string is a URL.
    /// </summary>
    /// <param name="path">The string to check.</param>
    /// <returns>True if the string is a URL, false otherwise.</returns>
    private static bool IsUrl(string path)
    {
        Uri uriResult;
        return Uri.TryCreate(path, UriKind.Absolute, out uriResult) &&
               (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
    }

    /// <summary>
    /// Reads the JSON content from the specified file path or URL, caching the content for future use.
    /// </summary>
    /// <param name="filePathOrUrl">The path to the JSON file or a publicly accessible URL.</param>
    /// <returns>The JSON content as a string, or null if an error occurs.</returns>
    private static string ReadJsonContent(string filePathOrUrl)
    {
        // Check if JSON content is already cached
        if (jsonCache.TryGetValue(filePathOrUrl, out string cachedJsonContent))
        {
            return cachedJsonContent;
        }

        try
        {
            string jsonContent;

            if (IsUrl(filePathOrUrl))
            {
                Console.WriteLine($"Reading JSON file from the web: {filePathOrUrl}");
                // Read JSON content from a URL
                using (WebClient webClient = new WebClient())
                {
                    jsonContent = webClient.DownloadString(filePathOrUrl);
                }
            }
            else
            {
                Console.WriteLine($"Reading JSON file from the local folder: {filePathOrUrl}");
                // Read JSON content from a local file path
                jsonContent = File.ReadAllText(filePathOrUrl);
            }

            // Cache the JSON content for future use
            jsonCache[filePathOrUrl] = jsonContent;

            //Console.WriteLine($"JSON content: {jsonContent}");
            return jsonContent;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading JSON content: {ex.Message}");
            return null;
        }
    }

}