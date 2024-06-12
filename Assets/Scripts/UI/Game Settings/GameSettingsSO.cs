using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

namespace RTS.UI
{
    public enum Difficulty
    {
        Easy,
        Medium,
        Hard
    }

    [CreateAssetMenu(menuName = "RTS/Game Settings", fileName = "New Game Settings")]
    public class GameSettingsSO : ScriptableObject
    {
        [SerializeField] [ReadOnly] private int _enemiesCount;
        [SerializeField] [ReadOnly] private Difficulty _difficulty;
        [SerializeField] [ReadOnly] private List<PlayerItemStack> _playersList;
        [SerializeField] [ReadOnly] private int _mapSize;

        public int EnemiesCount => _enemiesCount;
        public Difficulty Difficulty => _difficulty;
        public List<PlayerItemStack> Players => _playersList;
        public int MapSize => _mapSize;

        public void SetGameSettings(int enemies, int difficulty,  int mapSize)
        {
            _enemiesCount = enemies;
            _difficulty = (UI.Difficulty)difficulty;
            _mapSize = mapSize;
        }

        public void Clear()
        {
            _enemiesCount = -1;
            _playersList.Clear();
            _mapSize = -1;
        }
        
        public void Add(Player item, int count = 1)
        {
            if (count <= 0) return;
            _playersList.Add(new PlayerItemStack(item));
        }
    }
}