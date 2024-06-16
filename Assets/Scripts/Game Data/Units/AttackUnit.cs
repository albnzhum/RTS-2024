using System.Runtime.Serialization;

namespace RTS.Units
{
    [DataContract]
    public class AttackUnit : Unit
    {
        public float MinAttackDistance = default;
        public float MaxAttackDistance = default;
        public float AttackDelay = default;
        public int Damage = default;

        public AttackUnit(AttackUnitSO attackUnit) : base(attackUnit)
        {
            MinAttackDistance = attackUnit.MinAttackDistance;
            MaxAttackDistance = attackUnit.MaxAttackDistance;
            AttackDelay = attackUnit.AttackDelay;
            Damage = attackUnit.Damage;
        }
    }
}