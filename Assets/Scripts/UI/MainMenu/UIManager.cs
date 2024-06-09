using UnityEditor;
using UnityEngine;

namespace RTS.UI
{
    public class UIManager : MonoBehaviour
    {
        [Header("UI")]
        [SerializeField] private UIMenu menu;
        [SerializeField] private UIGeneralSettings generalSettings;
        [SerializeField] private UIGameSettings gameSettings;

        private void OnEnable()
        {
            menu.OnPlayButtonClicked += OpenGameSettings;
            menu.OnSettingsButtonClicked += OpenGeneralSettings;
            menu.OnQuitButtonClicked += QuitGame;
        }

        private void OnDisable()
        {
            menu.OnPlayButtonClicked -= OpenGameSettings;
            menu.OnSettingsButtonClicked -= OpenGeneralSettings;
            menu.OnQuitButtonClicked -= QuitGame;
        }

        private void OpenGameSettings()
        {
            gameSettings.Open();
        }

        private void OpenGeneralSettings()
        {
            generalSettings.Open();
        }

        private void QuitGame()
        {
#if UNITY_EDITOR
            EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
        }
        
    }
}
