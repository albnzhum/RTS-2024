using UnityEngine;

namespace RTS.Save
{
    public class SaveSystem : MonoBehaviour
    {
        public void SaveGeneralSettings(GeneralSettings settings)
        {
            FileManager.SerializeToJson(JsonFileName.GeneralSettingsFile, settings);
        }

        public GeneralSettings ReadGeneralSettings()
        {
            return FileManager.DeserializeFromJson<GeneralSettings>(JsonFileName.GeneralSettingsFile);
        }

        public GameData SaveGameData(GameData gameData, bool rewrite = false)
        {
            if (FileManager.IsFileEmpty<GameData>(JsonFileName.GameDataFile) || rewrite)
            {
                FileManager.Serialize(gameData, JsonFileName.GameDataFile);
                return null;
            }
            else
            {
                var units = FileManager.Deserialize<GameData>(JsonFileName.GameDataFile);
                return units;
            }
        }

        public GameData LoadGameData()
        {
            return FileManager.Deserialize<GameData>(JsonFileName.GameDataFile);
        }
    }
}