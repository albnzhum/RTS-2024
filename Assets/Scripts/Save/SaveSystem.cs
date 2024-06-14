using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RTS.Save
{
    public class SaveSystem : MonoBehaviour
    {
        public void SaveGeneralSettings(GeneralSettings settings)
        {
            FileManager.Write(JsonFileName.GeneralSettingsFile,settings);
        }

        public GeneralSettings ReadGeneralSettings()
        {
            return FileManager.Read<GeneralSettings>(JsonFileName.GeneralSettingsFile);
        }
    }
}
