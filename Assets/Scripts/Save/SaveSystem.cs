using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveSystem : MonoBehaviour
{
    public void SaveGeneralSettings(GeneralSettings settings)
    {
        FileManager.ToJson(settings);
    }
}
