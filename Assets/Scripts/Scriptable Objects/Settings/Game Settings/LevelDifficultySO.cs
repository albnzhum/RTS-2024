using System.Collections;
using System.Collections.Generic;
using RTS.UI;
using RTS.Units;
using UnityEngine;

public enum Difficulty
{
    Easy,
    Medium,
    Hard
}

[CreateAssetMenu(menuName = "RTS/Game Settings/Level Difficulty", fileName = "New Level Difficulty")]
public class LevelDifficultySO : ScriptableObject
{
    [SerializeField] private Difficulty difficulty;
    [SerializeField] private float enemiesSpawnTime;
    [SerializeField] private List<UnitTypeSO> enemiesUnitToSpawn;
    [SerializeField] private int startArmyLimit;
    [SerializeField] private int armyIncreaseValue;

    public Difficulty Difficulty => difficulty;
    public float EnemiesSpawnTime => enemiesSpawnTime;
    public List<UnitTypeSO> EnemiesUnitToSpawn => enemiesUnitToSpawn;
    public int StartArmyLimit => startArmyLimit;
    public int ArmyIncreaseValue => armyIncreaseValue;
}
