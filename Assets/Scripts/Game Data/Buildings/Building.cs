using System.Collections.Generic;
using System.Runtime.Serialization;
using RTS.Resources;

namespace RTS.Buildings
{
    public enum BuildingType
    {
        Barracks,
        House,
        Manufactory,
        Temple,
        Garden,
        Mill,
        GuardTower,
        Storage,
        CityHall,
        Foundry
    }
    
    [DataContract]
    public class Building
    {
        [DataMember] public string Name = default;
        [DataMember] public string Prefab = default;
        [DataMember] public BuildingType BuildingType = default;
        [DataMember] public int Strength = default;
        [DataMember] public List<ResourceCost> ResourceCosts = default;
    }
}
