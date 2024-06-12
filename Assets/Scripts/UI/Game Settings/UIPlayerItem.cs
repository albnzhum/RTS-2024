using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace RTS.UI
{
    public class UIPlayerItem : MonoBehaviour
    {
        [SerializeField] private TMP_InputField playerName;
        [SerializeField] private Button buttonColor;

        public UnityAction<Player> PlayerSelected;

        [HideInInspector] public PlayerItemStack currentPlayer;

        private bool _isSelected = false;

        private void OnEnable()
        {
            if (_isSelected)
            {
                SelectItem();
            }
        }

        public void SetItem(PlayerItemStack itemStack, bool isSelected)
        {
            _isSelected = isSelected;

            SetItemVisibility(true);

            currentPlayer = itemStack;

            playerName.text = itemStack.Player.Name;
            buttonColor.image.color = itemStack.Player.Color;
        }
        
        private void SetItemVisibility(bool visibility)
        {
            this.gameObject.SetActive(visibility);
        }

        public void SelectItem()
        {
            if (PlayerSelected != null && currentPlayer != null && currentPlayer.Player != null)
            {
                PlayerSelected.Invoke(currentPlayer.Player);
            }
        }

        public void SetInactiveItem()
        {
            currentPlayer = null;

            SetItemVisibility(false);
        }
    }
}