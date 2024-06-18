using System;
using UnityEngine.Serialization;

namespace RTS.Buildings
{
    [Serializable]
    public class GuardTower : Building
    {
        public float EnemyDetectionRadius;
        public float BuildingRadius;
        public int ArcherCapacity = 10;
        public float MinAttackDistance;
        public float MaxAttackDistance;
        public float AttackDelay;
        public int Damage;
    }
}