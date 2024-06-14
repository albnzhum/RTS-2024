using System;
using RTS.Events;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace RTS.UI
{
    public class UIResults : MonoBehaviour, IView
    {
        [SerializeField] private TMP_Text gameResultText;
        [SerializeField] private TMP_Text gameTimeText;
        [SerializeField] private TMP_Text killedUnitsText;
        [SerializeField] private TMP_Text lostUnitsText;

        public UnityAction BackToMenu;

        public void BackToMainMenu()
        {
            BackToMenu.Invoke();
        }

        public void Open()
        {
            
        }

        public void Close()
        {
            gameObject.SetActive(false);
        }
    }
}
