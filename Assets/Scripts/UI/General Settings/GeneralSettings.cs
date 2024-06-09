using System;
using UnityEngine;

[Serializable]
public class GeneralSettings
{
    [SerializeField] private bool isFullscreen;
    [SerializeField] private bool isAudioEnabled;
    [SerializeField] private float audioVolume;
    [SerializeField] private int resolutionIndex;

    public bool IsFullscreen => isFullscreen;
    public bool IsAudioEnabled => isAudioEnabled;
    public float AudioVolume => audioVolume;
    public int ResolutionIndex => resolutionIndex;

    public void SaveSettings(bool isFullscreen, bool isAudioEnabled, 
        float audioVolume, int resolution)
    {
        this.isFullscreen = isFullscreen;
        this.isAudioEnabled = isAudioEnabled;
        this.audioVolume = audioVolume;
        this.resolutionIndex = resolution;
    }
}
