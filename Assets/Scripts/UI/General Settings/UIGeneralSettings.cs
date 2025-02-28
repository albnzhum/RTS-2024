using System;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace RTS.UI
{
    public class UIGeneralSettings : MonoBehaviour, IView
    {
        [Header("UI Elements")]
        [SerializeField] public TMP_Dropdown resolutions;
        [SerializeField] public Toggle fullscreen;
        [SerializeField] public Toggle audioEnabled;
        [SerializeField] public Slider volume;
        
        public UnityAction OnResetSettings;
        public UnityAction<bool, bool, int, float> OnSaveSettings;
        public UnityAction<bool, bool, int, float> OnReadSettings;

        public UnityAction OnCloseEvent;

        private float _savedAudioVolume;
        private int _savedResolutionIndex;
        private bool _savedFullscreen;
        private bool _savedAudioEnabled;

        private void OnEnable()
        {
            fullscreen.onValueChanged.AddListener(SetFullscreenValue);
            audioEnabled.onValueChanged.AddListener(SetAudioEnabled);
            resolutions.onValueChanged.AddListener(SetResolutionIndex);
            volume.onValueChanged.AddListener(SetVolumeValue);
        }

        private void OnDisable()
        {
            fullscreen.onValueChanged.RemoveListener(SetFullscreenValue);
            audioEnabled.onValueChanged.RemoveListener(SetAudioEnabled);
            resolutions.onValueChanged.RemoveListener(SetResolutionIndex);
            volume.onValueChanged.RemoveListener(SetVolumeValue);
        }

        private void Awake()
        {
            OnReadSettings += ReadSettings;
        }

        private void SetFullscreenValue(bool isFullscreen)
        {
            _savedFullscreen = isFullscreen;
        }

        private void SetAudioEnabled(bool enabled)
        {
            _savedAudioEnabled = enabled;
        }

        private void SetResolutionIndex(int index)
        {
            _savedResolutionIndex = index;
        }

        private void SetVolumeValue(float value)
        {
            _savedAudioVolume = value;
        }

        public void ResetSettings()
        {
            OnResetSettings?.Invoke();
        }

        public void SaveSettings()
        {
            OnSaveSettings?.Invoke(_savedFullscreen, _savedAudioEnabled, 
                _savedResolutionIndex, _savedAudioVolume);
        }

        private void ReadSettings(bool fullscreen, bool audioEnabled, int resolutionIndex, float audioVolume)
        {
            this.fullscreen.isOn = fullscreen;
            this.audioEnabled.isOn = audioEnabled;
            resolutions.value = resolutionIndex;
            volume.value = audioVolume;
        }
        
        public void Open()
        {
            gameObject.SetActive(true);
        }

        public void Close()
        {
            gameObject.SetActive(false);
            
            OnCloseEvent.Invoke();
        }
    }
}
