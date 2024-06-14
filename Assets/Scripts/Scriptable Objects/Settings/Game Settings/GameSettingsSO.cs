using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

namespace RTS.UI
{
    [CreateAssetMenu(menuName = "RTS/Game Settings/Settings", fileName = "New Game Settings")]
    public class GameSettingsSO : ScriptableObject
    {
        [SerializeField] [ReadOnly] private int _enemiesCount;
        [SerializeField] [ReadOnly] private List<PlayerItemStack> _playersList;
        [SerializeField] [ReadOnly] private int _mapSize;
        [SerializeField] [ReadOnly] private List<LevelDifficultySO> _levelDifficulty;
        
        private LevelDifficultySO _currentLevelDifficulty;
        public int EnemiesCount => _enemiesCount;
        public List<PlayerItemStack> Players => _playersList;
        public int MapSize => _mapSize;
        public LevelDifficultySO CurrentLevelDifficulty => _currentLevelDifficulty;

        public void SetGameSettings(int enemies, int difficulty,  int mapSize)
        {
            _enemiesCount = enemies;
            _mapSize = mapSize;
            _currentLevelDifficulty = _levelDifficulty[difficulty];
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