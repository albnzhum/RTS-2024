using System;
using RTS.Events;
using UnityEngine;

namespace RTS.UI
{
    public class UIGameManager : MonoBehaviour
    {
        [Header("UI")] 
        [SerializeField] private UIResults results;
        [SerializeField] private UIPause pause;
        [SerializeField] private UIGeneralSettings settings;
        
        [Header("Listening To")]
        [SerializeField] private VoidEventChannelSO backToMainMenu;
        [SerializeField] private VoidEventChannelSO onSettingsEnabled;
        [SerializeField] private InputReader inputReader;

        private void OnEnable()
        {
            inputReader.OnOpenPauseEvent += OpenPause;

            results.BackToMenu += BackToMainMenu;
        }

        private void OnDisable()
        {
            inputReader.OnOpenPauseEvent -= OpenPause;
        }

        private void BackToMainMenu()
        {
            results.BackToMenu -= BackToMainMenu;
            backToMainMenu.RaiseEvent();
        }

        private void OpenPause()
        {
            pause.Open();
            
            inputReader.EnableUIInput();

            inputReader.OnClosePauseEvent += ClosePause;

            pause.GiveUpEvent += GiveUp;
            pause.OpenSettingsEvent += OpenSettings;
            
            Time.timeScale = 0;
        }

        private void ClosePause()
        {
            pause.GiveUpEvent -= GiveUp;
            pause.OpenSettingsEvent -= OpenSettings;
            
            pause.Close();
            
            Time.timeScale = 1;
            
            inputReader.EnableGameplayInput();
        }

        private void GiveUp()
        {
            
        }

        private void OpenSettings()
        {
            settings.Open();
            onSettingsEnabled.RaiseEvent();

            settings.OnCloseEvent += OpenPause;
        }
    }
}
