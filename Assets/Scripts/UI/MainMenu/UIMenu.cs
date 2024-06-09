using UnityEngine;
using UnityEngine.Events;

namespace RTS.UI
{
    public class UIMenu : MonoBehaviour, IView
    {
        public UnityAction OnPlayButtonClicked;
        public UnityAction OnSettingsButtonClicked;
        public UnityAction OnQuitButtonClicked;
        
        public void Play()
        {
            OnPlayButtonClicked?.Invoke();
        }

        public void Quit()
        {
            OnQuitButtonClicked?.Invoke();
        }

        public void OpenSettings()
        {
            OnSettingsButtonClicked?.Invoke();
        }

        public void Open()
        {
            gameObject.SetActive(true);
        }

        public void Close()
        {
            gameObject.SetActive(false);
        }
    }
}
