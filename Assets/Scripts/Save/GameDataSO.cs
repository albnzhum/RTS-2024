using System.Collections.Generic;
using RTS.Buildings;
using RTS.Units;
using UnityEngine;

[CreateAssetMenu(menuName = "RTS/Game Data", fileName = "New Game Data")]
public class GameDataSO : ScriptableObject
{
    [SerializeField] private List<BuildingSO> buildings;
    [SerializeField] private List<UnitSO> units;

    public List<BuildingSO> Buildings => buildings;
    public List<UnitSO> Units => units;
    
    public void SetBuildings(Building buildingToSet)
    {
        foreach (var building in buildings)
        {
            building.Set(buildingToSet);
        }
    }

    public void SetUnits(Unit unitToSet)
    {
        foreach (var unit in units)
        {
            unit.Set(unitToSet);
        }
    }
}
