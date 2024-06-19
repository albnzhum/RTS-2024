using RTS.UI;
using Unity.AI.Navigation;
using UnityEngine;

namespace RTS.Resources
{
    public class GameInitializer : MonoBehaviour
    {
        [SerializeField] private GameSettingsSO _gameSettings;

        [Header("Game")] 
        [SerializeField] private Terrain _terrain;

        [SerializeField] private NavMeshSurface _surface;

        private void Start()
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
            
            _surface.BuildNavMesh();
        }
    }
}