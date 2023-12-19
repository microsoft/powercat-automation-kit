using Microsoft.Xrm.Tooling.Connector;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

/// <summary>
/// Utility class for working with JSON data.
/// </summary>
public class JsonUtility
{
    /// <summary>
    /// Reads the PreDeploymentSettings from the specified JSON file for a given project name.
    /// </summary>
    /// <param name="filePath">The path to the JSON file.</param>
    /// <param name="projectName">The name of the project to retrieve PreDeploymentSettings for.</param>
    /// <returns>A dictionary containing the PreDeploymentSettings, or null if the project or settings are not found.</returns>
    public static Dictionary<string, string> ReadPreDeploymentSettings(string filePath, string projectName)
    {
        try
        {
            // Read the entire file content
            string jsonContent = File.ReadAllText(filePath);

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
    /// <param name="filePath">The path to the JSON file.</param>
    /// <param name="projectName">The name of the project to retrieve PostDeploymentSettings for.</param>
    /// <returns>A dictionary containing the PostDeploymentSettings, or null if the project or settings are not found.</returns>
    public static Dictionary<string, string> ReadPostDeploymentSettings(string filePath, string projectName)
    {
        try
        {
            // Read the entire file content
            string jsonContent = File.ReadAllText(filePath);

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
}
