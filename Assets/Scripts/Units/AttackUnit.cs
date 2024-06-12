using System;
using UnityEngine;

namespace RTS.Units
{
    [Serializable]
    public class AttackUnit : Unit
    {
        [SerializeField] private float minAttackDistance;
        [SerializeField] private float maxAttackDistance;
        [SerializeField] private float delayAttacks;
        [SerializeField] private int damage;

        public float MinAttackDistance => minAttackDistance;
        public float MaxAttackDistance => maxAttackDistance;
        public float DelayAttacks => delayAttacks;
        public int Damage => damage;
    }
}