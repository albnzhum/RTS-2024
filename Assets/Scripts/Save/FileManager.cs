using System;
using System.IO;
using UnityEngine;

public static class FileManager
{
    private static string generalSettingsFileName = "GeneralSettings.json";

    public static void ToJson(GeneralSettings settings)
    {
        string filePath = Path.Combine(Application.streamingAssetsPath, generalSettingsFileName);
        try
        {
            {
                string json = JsonUtility.ToJson(settings);
                File.WriteAllText(filePath, json);
            }
        }
        catch (Exception e)
        {
            Debug.LogError("Error creating levels file: " + e.Message);
        }
    }
}