using System;
using System.Collections.Generic;
using RTS.Resources;
using UnityEngine;

namespace RTS.Buildings
{
    [Serializable]
    public class BuildingSO : ScriptableObject
    {
        [Header("General")]
        [SerializeField] private new string name;
        [SerializeField] private GameObject prefab;
        
        [Header("Metrics")]
        [SerializeField] private BuildingType buildingType;
        [SerializeField] private int strength = default;
        [SerializeField] private List<ResourceCost> resourceCosts;

        public string Name => name;
        public GameObject Prefab => prefab;
        public BuildingType BuildingType => buildingType;
        public int Strength => strength;
        public List<ResourceCost> ResourceCosts => resourceCosts;

        public virtual void Set<T>(T building) where T : Building
        {
            name = building.Name;
            prefab = building.Prefab;
            buildingType = building.BuildingType;
            strength = building.Strength;
            resourceCosts = building.ResourceCosts;
        }

        public virtual Building ToBuilding<T>() where T : BuildingSO
        {
            return new Building(this);
        }
    }
}