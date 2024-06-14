using System;
using System.Collections.Generic;
using RTS.Events;
using RTS.Save;
using UnityEngine;

namespace RTS.UI
{
    public class GeneralSettingsController : MonoBehaviour
    {
        [SerializeField] private UIGeneralSettings uiGameSettings;
        [SerializeField] private SaveSystem saveSystem;
        [SerializeField] private VoidEventChannelSO onSettingsEnabled;

        private GeneralSettings _generalSettings;

        private List<Resolution> _resolutions;
        private Resolution _currentResolution;

        private void OnEnable()
        {
            _generalSettings = saveSystem.ReadGeneralSettings();

            uiGameSettings.OnSaveSettings += SaveSettings;

            onSettingsEnabled.OnEventRaised += SetCurrentSettingsUI;

            SetResolutionsList();
        }

        private void OnDisable()
        {
            uiGameSettings.OnSaveSettings -= SaveSettings;

            onSettingsEnabled.OnEventRaised -= SetCurrentSettingsUI;
        }

        private void SetCurrentSettingsUI()
        {
            uiGameSettings.OnReadSettings.Invoke(_generalSettings.IsFullscreen, _generalSettings.IsAudioEnabled,
                _generalSettings.ResolutionIndex, _generalSettings.AudioVolume);
        }

        private void SaveSettings(bool fullscreen, bool audioEnabled, int resolutionIndex, float audioVolume)
        {
            _generalSettings.SaveSettings(fullscreen, audioEnabled, audioVolume, resolutionIndex);
            saveSystem.SaveGeneralSettings(_generalSettings);
            SetCurrentSettings();
        }

        private void SetCurrentSettings()
        {
            _currentResolution = GetCurrentResolution(_generalSettings.ResolutionIndex);

            FullScreenMode fullscreenMode =
                _generalSettings.IsFullscreen ? FullScreenMode.ExclusiveFullScreen : FullScreenMode.Windowed;
            Screen.SetResolution(_currentResolution.width, _currentResolution.height, fullscreenMode);
        }

        private void SetResolutionsList()
        {
            _resolutions = GetResolutionsList();

            uiGameSettings.resolutions.ClearOptions();

            List<string> options = new List<string>();

            int currentResolutionIndex = 0;

            foreach (Resolution res in Screen.resolutions)
            {
                _resolutions.Add(res);
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
            if (_resolutions == null)
            {
                _resolutions = GetResolutionsList();
            }

            _currentResolution = _resolutions[index];
            return _currentResolution;
        }

        int GetCurrentResolutionIndex()
        {
            if (_resolutions == null)
            {
                _resolutions = GetResolutionsList();
            }

            int index = _resolutions.FindIndex(o =>
                o.width == _currentResolution.width && o.height == _currentResolution.height);
            return index;
        }
    }
}