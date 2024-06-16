using UnityEngine;

namespace RTS.Buildings
{
    public enum BuildingType
    {
        Barracks,
        House,
        Manufactory,
        Church,
        Garden,
        Mill,
        GuardTower,
        Storage,
        CityHall,
        Foundry
        
    }
    
    [CreateAssetMenu(menuName = "RTS/Building/Building Type", fileName = "New Building Type")]
    public class BuildingTypeSO : ScriptableObject
    {
        [SerializeField] private BuildingType buildingType;
        public BuildingType BuildingType => buildingType;
    }
}