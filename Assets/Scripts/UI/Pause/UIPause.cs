using System;
using UnityEngine;
using UnityEngine.Events;

namespace RTS.UI
{
    public class UIPause : MonoBehaviour, IView
    {
        public UnityAction GiveUpEvent;
        public UnityAction OpenSettingsEvent;

        public void OpenSettings()
        {
            OpenSettingsEvent.Invoke();
        }

        public void GiveUp()
        {
            GiveUpEvent.Invoke();
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