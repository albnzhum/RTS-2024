using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "RTS/Game Settings/Session", fileName = "New Game Session")]
public class GameSessionSO : ScriptableObject
{
    [SerializeField] private List<LevelDifficultySO> levelModifiers = default;
    [SerializeField] private int buildingRadius = default;

    public List<LevelDifficultySO> LevelModifiers => levelModifiers;
    public int BuildingRadius => buildingRadius;

    public void Set(GameSessionSO session)
    {
        levelModifiers = session.LevelModifiers;
        buildingRadius = session.BuildingRadius;
    }

    public void Clear()
    {
        levelModifiers.Clear();
        buildingRadius = 0;
    }
}