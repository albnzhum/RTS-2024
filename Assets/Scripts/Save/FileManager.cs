using System;
using System.IO;
using UnityEngine;

namespace RTS.Save
{
    public static class FileManager
    {
        private static string generalSettingsFileName = "GeneralSettings.json";

        public static void WriteSettings(GeneralSettings settings)
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
                Debug.LogError("Error creating file: " + e.Message);
            }
        }

        public static GeneralSettings ReadSettings()
        {
            string filePath = Path.Combine(Application.streamingAssetsPath, generalSettingsFileName);

            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                GeneralSettings settings = JsonUtility.FromJson<GeneralSettings>(json);

                return settings;
            }
            else
            {
                return new GeneralSettings();
            }
        }
    }
}