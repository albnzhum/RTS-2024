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

        public void SaveGameData(GameData gameData)
        {
            FileManager.Serialize(gameData, JsonFileName.GameDataFile);
        }

        public GameData LoadGameData()
        {
            return FileManager.Deserialize<GameData>(JsonFileName.GameDataFile);
        }
    }
}
