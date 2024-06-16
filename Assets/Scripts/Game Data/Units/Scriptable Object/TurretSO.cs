using UnityEngine;

namespace RTS.Units
{
    [CreateAssetMenu(menuName = "RTS/Units/Turret", fileName = "New Turrer")]
    public class TurretSO : UnitSO
    {
        [SerializeField] private float minAttackDistance = 2;
        [SerializeField] private float maxAttackDistance = 8;
        [SerializeField] private int damage = default;
        [SerializeField] private int capacity = 10;

        public float MinAttackDistance => minAttackDistance;
        public float MaxAttackDistance => maxAttackDistance;
        public int Damage => damage;
        public int Capacity => capacity;

        public override void Set<T>(T unit)
        {
            base.Set(unit);

            if (unit is Turret turret)
            {
                minAttackDistance = turret.MinAttackDistance;
                maxAttackDistance = turret.MaxAttackDistance;
                damage = turret.Damage;
                capacity = turret.Capacity;
            }
        }

        public override Unit ToUnit<T>()
        {
            return new Turret(this);
        }
    }
}