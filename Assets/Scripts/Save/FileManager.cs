using System;
using System.IO;
using System.Runtime.Serialization.Json;
using RTS.Units;
using UnityEngine;

namespace RTS.Save
{
    public static class FileManager
    {
        static Type[] knownTypes = new Type[] { typeof(AttackUnit), typeof(Builder), typeof(Healer), typeof(Turret) };
        
        public static void Serialize<T>(T obj, string fileName)
        {
            string path = Path.Combine(Application.streamingAssetsPath, fileName);
            
            using (MemoryStream stream = new MemoryStream())
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T), knownTypes);
                serializer.WriteObject(stream, obj);
                stream.Position = 0;
                
                using (StreamReader reader = new StreamReader(stream))
                {
                    string json = reader.ReadToEnd();
                    File.WriteAllText(path, json);
                }
            }
        }

        public static T Deserialize<T>(string fileName)
        {
            string path = Path.Combine(Application.streamingAssetsPath, fileName);

            string json = File.ReadAllText(path);
            
            using (MemoryStream stream = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(json)))
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T), knownTypes);
                return (T)serializer.ReadObject(stream);
            }
        }
        
        public static bool IsFileEmpty<T>(string filename)
        {
            string filePath = Path.Combine(Application.streamingAssetsPath, filename);

            try
            {
                string text = File.ReadAllText(filePath);

                T obj = JsonUtility.FromJson<T>(text);

                if (obj == null)
                {
                    return true;
                }

                return false;
            }
            catch (Exception e)
            {
                Debug.LogError("Couldn't read file: " + e.Message);
            }

            return true;
        }

        public static void SerializeToJson<T>(string fileName, T obj)
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

        public static T DeserializeFromJson<T>(string filename)
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