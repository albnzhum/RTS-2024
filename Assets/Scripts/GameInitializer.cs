using System;
using RTS.UI;
using UnityEngine;

namespace RTS.Resources
{
    public class GameInitializer : MonoBehaviour
    {
        [SerializeField] private GameSettingsSO _gameSettings;

        [Header("Game")] 
        [SerializeField] private Terrain _terrain;

        private void OnEnable()
        {
            SetMapArea();
        }

        private void OnDisable()
        {
            _gameSettings.Clear();
        }

        private void SetMapArea()
        {
            var width = Mathf.Sqrt(_gameSettings.MapSize);
            
            _terrain.terrainData.size = new Vector3(width, 10, width);
        }
        
        
    }
}