using System.Collections.Generic;
using RTS.UI;
using RTS.Units;
using TMPro;
using UnityEngine;

public class FactionSlot : MonoBehaviour
{
    [SerializeField] private List<UnitSO> _unitsToSpawn;

    [Header("UI")] 
    [SerializeField] private TMP_Text playerName;
    
    public Player CurrentPlayer { get; set; }

    private void Start()
    {
        playerName.text = CurrentPlayer.Name;
        
        List<Vector3> unitPositions = GetUnitPositions(transform.position);

        int unitIndex = 0;
        foreach (var unit in _unitsToSpawn)
        {
            var currentUnit = unit.ToUnit();
            
            if (currentUnit.UnitType == UnitType.Builder || currentUnit.UnitType == UnitType.Archer)
            {
                for (int i = 0; i < (currentUnit.UnitType == UnitType.Builder ? 3 : 2); i++)
                {
                    GameObject unitGO = Instantiate(GetUnitPrefab(currentUnit), unitPositions[unitIndex], Quaternion.identity);
                    unitIndex++;
                }
            }
        }
    }
    
    private GameObject GetUnitPrefab(Unit unit)
    {
        if (unit == null || string.IsNullOrEmpty(unit.PrefabName))
        {
            Debug.LogError("Unit or PrefabName is not set.");
            return null;
        }
        var prefab = Resources.Load<GameObject>(unit.PrefabName);
        if (prefab == null)
        {
            Debug.LogError($"Prefab not found at path: {unit.PrefabName}");
        }
        return prefab;
    }
    
    private List<Vector3> GetUnitPositions(Vector3 townHallPosition)
    {
        List<Vector3> positions = new List<Vector3>();

        float offsetX = 5.0f;

        for (int i = 0; i < 6; i++)
        {
            Vector3 position = new Vector3(townHallPosition.x + offsetX * i, townHallPosition.y, townHallPosition.z - offsetX);
            positions.Add(position);
        }

        return positions;
    }
}
