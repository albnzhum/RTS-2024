using System;
using System.Collections.Generic;
using RTS.Resources;
using UnityEngine;

namespace RTS.Buildings
{
    [Serializable]
    public class Building
    {
        public string Name = default;
        public GameObject Prefab = default;
        public BuildingType BuildingType = default;
        public int Strength = default;
        public List<ResourceCost> ResourceCosts = default;

        public Building(BuildingSO building)
        {
            Name = building.Name;
            Prefab = building.Prefab;
            BuildingType = building.BuildingType;
            Strength = building.Strength;
            ResourceCosts = building.ResourceCosts;
        }
    }
}
