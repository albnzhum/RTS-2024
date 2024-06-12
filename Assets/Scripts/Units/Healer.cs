using System;
using UnityEngine;


namespace RTS.Units
{
    [Serializable]
    public class Healer : Unit
    {
        [SerializeField] private float minHealDistance;
        [SerializeField] private float maxHealDistance;
        [SerializeField] private float healDelay;
        [SerializeField] private int heal;

        public float MinHealDistance => minHealDistance;
        public float MaxHealDistance => maxHealDistance;
        public float HealDelay => healDelay;
        public int Heal => heal;
    }
}