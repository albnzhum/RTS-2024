using System;
using System.Collections.Generic;
using RTS.Events;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using Random = System.Random;

namespace RTS.UI
{
    public class UIGameSettings : MonoBehaviour, IView
    {
        public List<Color> Colors = new List<Color>();

        [SerializeField] private GameSettingsSO _gameSettings = default;
        [SerializeField] private List<UIPlayerItem> availableItemSlots = default;
        [SerializeField] private VoidEventChannelSO onGameplaySceneLoad = default;

        [Header("UI")] 
        [SerializeField] private TMP_Dropdown playersCount;
        [SerializeField] private TMP_Dropdown difficulty;
        [SerializeField] private TMP_InputField mapSizeInputField;

        public UnityAction OnSaveGameSettings;

        private int _selectedItemId = -1;
        
        private bool isMapSizeValid = false;

        #region Unity

        private void OnEnable()
        {
            for (int i = 0; i < availableItemSlots.Count; i++)
            {
                availableItemSlots[i].PlayerSelected += InspectItem;
            }

            playersCount.onValueChanged.AddListener(SetPlayerCount);

            InitializePlayers();
        }

        private void OnDisable()
        {
            for (int i = 0; i < availableItemSlots.Count; i++)
            {
                availableItemSlots[i].PlayerSelected -= InspectItem;
            }

            //_gameSettings.Clear();
        }

        #endregion

        public void Play()
        {
            if (ValidateSettings())
            {
                SaveSettings();
                onGameplaySceneLoad.RaiseEvent();
            }
            else
            {
                Debug.Log("Settings not validate");
            }
        }

        private void SaveSettings()
        {
            int playerCountOptionValue = playersCount.value;
            int playersCountValue = Convert.ToInt32(playersCount.options[playerCountOptionValue].text);

            int difficultyOptionValue = difficulty.value;

            var mapSizeValue = int.TryParse(mapSizeInputField.text, out int mapSize);
            
            _gameSettings.SetGameSettings(playersCountValue, difficultyOptionValue, mapSize);
        }

        private void InitializePlayers()
        {
            Random rnd = new Random();
            int playerColorIndex = rnd.Next(Colors.Count);
            int opponentColorIndex = (playerColorIndex + 1) % Colors.Count;

            Player mainPlayer = new("Игрок", Colors[playerColorIndex]);
            Player opponent = new("Противник 1", Colors[opponentColorIndex]);

            _gameSettings.Add(mainPlayer);
            _gameSettings.Add(opponent);

            FillItems(_gameSettings.Players);
        }

        public void SetPlayerCount(int count)
        {
            int value = Convert.ToInt32(playersCount.options[count].text);
            int currentOpponents = _gameSettings.Players.Count - 1;

            if (value > currentOpponents)
            {
                AddOpponents(value - currentOpponents);
            }
            else if (value < currentOpponents)
            {
                RemoveOpponents(currentOpponents - value);
            }

            FillItems(_gameSettings.Players);
        }

        private void AddOpponents(int count)
        {
            Random rnd = new Random();
            for (int i = 0; i < count; i++)
            {
                int colorIndex = rnd.Next(Colors.Count);

                while (_gameSettings.Players.Exists(p => p.Player.Color == Colors[colorIndex]))
                {
                    colorIndex = rnd.Next(Colors.Count);
                }

                Player opponent = new Player($"Противник {_gameSettings.Players.Count}", Colors[colorIndex]);

                _gameSettings.Add(opponent);
            }
        }

        private void RemoveOpponents(int count)
        {
            for (int i = 0; i < count; i++)
            {
                _gameSettings.Players.RemoveAt(_gameSettings.Players.Count - 1);
            }
        }

        private bool ValidateSettings()
        {
            bool valid = true;

            HashSet<string> names = new HashSet<string>();

            foreach (var player in _gameSettings.Players)
            {
                if (!names.Add(player.Player.Name))
                {
                    valid = false;
                    break;
                }
            }

            if (!int.TryParse(mapSizeInputField.text, out int mapSize) || mapSize < 2500 || mapSize > 10000)
            {
                valid = false;
            }
            else
            {
                int side = Mathf.RoundToInt(Mathf.Sqrt(mapSize));
                mapSize = side * side;
                mapSizeInputField.text = mapSize.ToString();
            }

            if (_gameSettings.Players.Count < 2)
            {
                valid = false;
            }

            return valid;
        }

        /// <summary>
        /// Обновление отображения доступных элементов 
        /// </summary>
        /// <param name="listItemsToShow"></param>
        private void FillItems(List<PlayerItemStack> listItemsToShow)
        {
            if (availableItemSlots == null)
                availableItemSlots = new List<UIPlayerItem>();

            int maxCount = Mathf.Max(listItemsToShow.Count, availableItemSlots.Count);

            for (int i = 0; i < maxCount; i++)
            {
                if (i < listItemsToShow.Count)
                {
                    bool isSelected = _selectedItemId == i;
                    availableItemSlots[i].SetItem(listItemsToShow[i], isSelected);
                }
                else if (i < availableItemSlots.Count)
                {
                    availableItemSlots[i].SetInactiveItem();
                }
            }

            if (_selectedItemId >= 0)
            {
                _selectedItemId = -1;
            }
        }

        private void InspectItem(Player itemToInspect)
        {
            if (availableItemSlots.Exists(o => o.currentPlayer.Player == itemToInspect))
            {
                int itemIndex = availableItemSlots.FindIndex(o => o.currentPlayer.Player == itemToInspect);

                _selectedItemId = itemIndex;
            }
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