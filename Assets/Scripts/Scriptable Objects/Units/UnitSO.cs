using System.Collections.Generic;
using RTS.Resources;
using UnityEngine;

namespace RTS.Units
{
    
    
    public class UnitSO : ScriptableObject
    {
        [SerializeField] protected string name = default;
        [SerializeField] protected GameObject prefab;
        [SerializeField] protected UnitTypeSO unitType = default;
        [SerializeField] protected float movementSpeed = default;
        [SerializeField] protected int health = default;
        [SerializeField] protected List<ResourceCost> resourceCost = new List<ResourceCost>();
        [SerializeField] protected float detectionRange = default;

        public string Name => name;
        public GameObject Prefab => prefab;
        public UnitTypeSO UnitType => unitType;
        public float MovementSpeed => movementSpeed;
        public int Health => health;
        public List<ResourceCost> ResourceCost => resourceCost;
        public float DetectionRange => detectionRange;

        protected virtual void Set<T>(T unit) where T : UnitSO
        {
            name = unit.Name;
            unitType = unit.UnitType;
            movementSpeed = unit.MovementSpeed;
            health = unit.Health;
            resourceCost = unit.ResourceCost;
            detectionRange = unit.DetectionRange;
        }
    }
}
