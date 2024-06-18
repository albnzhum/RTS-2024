using RTS.Buildings;
using RTS.Units;
using UnityEngine;

namespace RTS.Save
{
    /// <summary>
    /// Класс для чтения и сохранения данных о юнитах
    /// </summary>
    public class GameDataReader : MonoBehaviour
    {
        [SerializeField] private GameDataSO gameDataSO;
        [SerializeField] private SaveSystem saveSystem;

        private GameData gameData;

        private void Init()
        {
            gameData = new GameData();

            foreach (var unitSO in gameDataSO.Units)
            {
                var unit = unitSO.ToUnit<Unit>();
                gameData.Units.Add(unit);
            }

            foreach (var buildingSO in gameDataSO.Buildings)
            {
                var building = buildingSO.ToBuilding<Building>();
                gameData.Buildings.Add(building);
            }

            saveSystem.SaveGameData(gameData, true);
        }

        private void OnEnable()
        {
            gameData = saveSystem.SaveGameData(gameData);
            
            foreach (var unit in gameData.Units)
            {
                gameDataSO.SetUnits(unit);
            }
        }
    }
}