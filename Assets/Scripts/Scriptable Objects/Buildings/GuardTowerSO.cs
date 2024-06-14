using UnityEngine;

namespace RTS.Buildings
{
    [CreateAssetMenu(menuName = "RTS/Building/Guard Tower", fileName = "New Guard Tower")]
    public class GuardTowerSO : BuildingSO
    {
        [SerializeField] private float enemyDetectionRadius;
        [SerializeField] private float buildingRadius;
        [SerializeField] private int archerCapacity = 10;
        [SerializeField] private float minAttackDistance;
        [SerializeField] private float maxAttackDistance;
        [SerializeField] private float attackDelay;
        [SerializeField] private int damage;

        public float EnemyDetectionRadius => enemyDetectionRadius;
        public float BuildingRadius => buildingRadius;
        public int ArcherCapacity => archerCapacity;
        public float MinAttackDistance => minAttackDistance;
        public float MaxAttackDistance => maxAttackDistance;
        public float AttackDelay => attackDelay;
        public int Damage => damage;

        public override void Set<T>(T building)
        {
            base.Set(building);

            if (building is GuardTowerSO guardTower)
            {
                enemyDetectionRadius = guardTower.EnemyDetectionRadius;
                buildingRadius = guardTower.BuildingRadius;
                archerCapacity = guardTower.ArcherCapacity;
                minAttackDistance = guardTower.MinAttackDistance;
                maxAttackDistance = guardTower.MaxAttackDistance;
                attackDelay = guardTower.AttackDelay;
                damage = guardTower.Damage;
            }
        }
    }
}