using System;
using System.Runtime.Serialization;

namespace RTS.Units
{
    [Serializable]
    public class AttackUnit : Unit
    {
        public float MinAttackDistance = default;
        public float MaxAttackDistance = default;
        public float AttackDelay = default;
        public int Damage = default;
    }
}