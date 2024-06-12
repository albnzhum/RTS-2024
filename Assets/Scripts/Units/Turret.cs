using System;
using UnityEngine;

namespace RTS.Units
{
    [Serializable]
    public class Turret : Unit
    {
        [SerializeField] private float minAttackDistance = 2;
        [SerializeField] private float maxAttackDistance = 8;
        [SerializeField] private int damage = 5;
        [SerializeField] private int capacity = 10;

        public float MinAttackDistance => minAttackDistance;
        public float MaxAttackDistance => maxAttackDistance;
        public int Damage => damage;
        public int Capacity => capacity;
    }
}