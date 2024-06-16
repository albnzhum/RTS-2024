using UnityEngine;

namespace RTS.Units
{
    [CreateAssetMenu(menuName = "RTS/Units/Attack Unit", fileName = "New Attack Unit")]
    public class AttackUnitSO : UnitSO
    {
        [SerializeField] private float minAttackDistance = default;
        [SerializeField] private float maxAttackDistance = default;
        [SerializeField] private float attackDelay = default;
        [SerializeField] private int damage = default;

        public float MinAttackDistance => minAttackDistance;
        public float MaxAttackDistance => maxAttackDistance;
        public float AttackDelay => attackDelay;
        public int Damage => damage;

        public override void Set<T>(T unit)
        {
            base.Set(unit);

            if (unit is AttackUnit attackUnit)
            {
                minAttackDistance = attackUnit.MinAttackDistance;
                maxAttackDistance = attackUnit.MaxAttackDistance;
                attackDelay = attackUnit.AttackDelay;
                damage = attackUnit.Damage;
            }
        }

        public override Unit ToUnit<T>()
        {
            return new AttackUnit(this);
        }
    }
}
