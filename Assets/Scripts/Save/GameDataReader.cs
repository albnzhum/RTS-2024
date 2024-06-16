using RTS.Units;
using UnityEngine;

namespace RTS.Save
{
    public class GameDataReader : MonoBehaviour
    {
        [SerializeField] private GameDataSO gameDataSO;
        [SerializeField] private SaveSystem saveSystem;

        private GameData gameData;
        
        private void OnEnable()
        {
            gameData = new GameData();

            foreach (var unitSO in gameDataSO.Units)
            {
                var unit = unitSO.ToUnit<UnitSO>();
                gameData.Units.Add(unit);
            }

            saveSystem.SaveGameData(gameData);
        }
    }
}