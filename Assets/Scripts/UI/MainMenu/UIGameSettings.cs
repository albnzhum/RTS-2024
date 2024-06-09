using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace RTS.UI
{
    public class UIGameSettings : MonoBehaviour, IView
    {
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
