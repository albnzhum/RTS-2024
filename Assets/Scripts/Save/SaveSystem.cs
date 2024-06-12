using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RTS.Save
{
    public class SaveSystem : MonoBehaviour
    {
        public void SaveGeneralSettings(GeneralSettings settings)
        {
            FileManager.WriteSettings(settings);
        }
    }
}
