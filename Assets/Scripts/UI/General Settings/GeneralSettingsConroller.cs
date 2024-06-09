using System.Collections.Generic;
using RTS.UI;
using UnityEngine;
using UnityEngine.Events;

public class GeneralSettingsConroller : MonoBehaviour
{
    [SerializeField] private UIGeneralSettings uiGameSettings;
    [SerializeField] private SaveSystem _saveSystem;

    private GeneralSettings _generalSettings;

    private List<Resolution> resolutions;
    private Resolution _currentResolution;

    private void OnEnable()
    {
        _generalSettings = new GeneralSettings();
        
        SetResolutionsList();

        uiGameSettings.OnSaveSettings += SaveSettings;
    }

    private void SaveSettings(bool fullscreen, bool audioEnabled, int resolutionIndex, float audioVolume)
    {
        _generalSettings.SaveSettings(fullscreen, audioEnabled, audioVolume, resolutionIndex);
        _saveSystem.SaveGeneralSettings(_generalSettings);
        SetCurrentSettings();
    }

    private void SetCurrentSettings()
    {
        _currentResolution = GetCurrentResolution(_generalSettings.ResolutionIndex);
        Screen.fullScreen = _generalSettings.IsFullscreen;
        Screen.SetResolution(_currentResolution.width, _currentResolution.height, Screen.fullScreen);
    }

    private void SetResolutionsList()
    {
        resolutions = GetResolutionsList();

        uiGameSettings.resolutions.ClearOptions();

        List<string> options = new List<string>();

        int currentResolutionIndex = 0;
        
        foreach (Resolution res in Screen.resolutions)
        {
            resolutions.Add(res);
            string option = res.width + " x " + res.height;
            options.Add(option);
        }
        
        uiGameSettings.resolutions.AddOptions(options);
    }
    
    List<Resolution> GetResolutionsList()
    {
        List<Resolution> options = new List<Resolution>();
        for (int i = 0; i < Screen.resolutions.Length; i++)
        {
            options.Add(Screen.resolutions[i]);
        }

        return options;
    }

    Resolution GetCurrentResolution(int index)
    {
        if (resolutions == null)
        { resolutions = GetResolutionsList(); }

        _currentResolution = resolutions[index];
        return _currentResolution;
    }
    
    int GetCurrentResolutionIndex()
    {
        if (resolutions == null)
        { resolutions = GetResolutionsList(); }
        int index = resolutions.FindIndex(o => o.width == _currentResolution.width && o.height == _currentResolution.height);
        return index;
    }
}
