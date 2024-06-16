using System.Collections.Generic;
using RTS.Resources;
using UnityEngine;

namespace RTS.Units
{
    public class Unit
    {
        public string Name;
        public GameObject Prefab;
        public UnitType UnitType;
        public float MovementSpeed;
        public int Health;
        public List<ResourceCost> ResourceCost;
        public float DetectionRange;

        public Unit(UnitSO unit)
        {
            Name = unit.Name;
            Prefab = unit.Prefab;
            UnitType = unit.UnitType;
            MovementSpeed = unit.MovementSpeed;
            Health = unit.Health;
            ResourceCost = new List<ResourceCost>(unit.ResourceCost);
            DetectionRange = unit.DetectionRange;
        }
    }
}