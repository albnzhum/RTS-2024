using System;
using System.Collections.Generic;
using UnityEngine;

namespace RTS.Units
{
    public enum UnitType
    {
        Archer,
        Catapult,
        HeavyWarrior,
        Lancer,
        Builder,
        Healer,
        Turret
    }
    
    [Serializable]
    public class Unit
    {
        [SerializeField] private string name;
        [SerializeField] private UnitType unitType;
        [SerializeField] private float movementSpeed;
        [SerializeField] private int health;
        [SerializeField] private List<ResourceCost> resourcesCost;
        [SerializeField] private float detectionRange;

        public string Name => name;
        public UnitType UnitType => unitType;
        public float MovementSpeed => movementSpeed;
        public int Health => health;
        public List<ResourceCost> ResourceCosts => resourcesCost;
        public float DetectionRange => detectionRange;
    }
}