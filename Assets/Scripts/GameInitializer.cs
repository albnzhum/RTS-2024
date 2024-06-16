using RTS.UI;
using UnityEngine;

namespace RTS.Resources
{
    public class GameInitializer : MonoBehaviour
    {
        [SerializeField] private GameSettingsSO _gameSettings;

        [Header("Game")] [SerializeField] private Terrain _terrain;

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
            _terrain.terrainData.size = new Vector3(_gameSettings.MapSize * 2, 10, _gameSettings.MapSize * 2);
        }
    }
}