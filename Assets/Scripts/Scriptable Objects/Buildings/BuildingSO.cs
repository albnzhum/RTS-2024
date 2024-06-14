using System.Collections.Generic;
using RTS.Resources;
using UnityEngine;

namespace RTS.Buildings
{
    public class BuildingSO : ScriptableObject
    {
        [Header("General")]
        [SerializeField] private string name;
        [SerializeField] private GameObject prefab;
        
        [Header("Metrics")]
        [SerializeField] private BuildingTypeSO buildingType;
        [SerializeField] private int strength = default;
        [SerializeField] private List<ResourceCost> resourceCosts;

        public string Name => name;
        public GameObject Prefab => prefab;
        public BuildingTypeSO BuildingType => buildingType;
        public int Strength => strength;
        public List<ResourceCost> ResourceCosts => resourceCosts;

        public virtual void Set<T>(T building) where T : BuildingSO
        {
            strength = building.Strength;
            resourceCosts = building.ResourceCosts;
        }
    }
}