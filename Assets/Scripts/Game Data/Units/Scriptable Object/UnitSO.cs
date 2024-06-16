using System.Collections.Generic;
using RTS.Resources;
using UnityEngine;

namespace RTS.Units
{
    public abstract class UnitSO : ScriptableObject
    {
        [SerializeField] protected new string name = default;
        [SerializeField] protected GameObject prefab;
        [SerializeField] protected UnitType unitType = default;
        [SerializeField] protected float movementSpeed = default;
        [SerializeField] protected int health = default;
        [SerializeField] protected List<ResourceCost> resourceCost = new List<ResourceCost>();
        [SerializeField] protected float detectionRange = default;

        public string Name => name;
        public GameObject Prefab => prefab;
        public UnitType UnitType => unitType;
        public float MovementSpeed => movementSpeed;
        public int Health => health;
        public List<ResourceCost> ResourceCost => resourceCost;
        public float DetectionRange => detectionRange;

        public virtual void Set<T>(T unit) where T : Unit
        {
            name = unit.Name;
            prefab = unit.Prefab;
            unitType= unit.UnitType;
            movementSpeed = unit.MovementSpeed;
            health = unit.Health;
            resourceCost = unit.ResourceCost;
            detectionRange = unit.DetectionRange;
        }

        public abstract Unit ToUnit<T>() where T : UnitSO;
    }
}
