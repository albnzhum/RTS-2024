using System;
using System.IO;
using UnityEngine;

namespace RTS.Save
{
    public static class FileManager
    {
        public static void Write<T>(string fileName, T obj)
        {
            string filePath = Path.Combine(Application.streamingAssetsPath, fileName);

            try
            {
                string json = JsonUtility.ToJson(obj);

                File.WriteAllText(filePath, json);
            }
            catch (Exception e)
            {
                Debug.LogError("Error creating file " + e.Message);
            }
        }

        public static T Read<T>(string filename)
        {
            string filePath = Path.Combine(Application.streamingAssetsPath, filename);

            try
            {
                if (File.Exists(filePath))
                {
                    string json = File.ReadAllText(filePath);

                    T obj = JsonUtility.FromJson<T>(json);

                    return obj;
                }
            }
            catch (Exception e)
            {
                Debug.LogError("Error reading file " + e.Message);
            }

            return default;
        }
    }
}