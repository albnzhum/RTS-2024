using UnityEngine;

namespace RTS.Buildings
{
    [CreateAssetMenu(menuName = "RTS/Building/Train Building", fileName = "New Train Building")]
    public class TrainBuildingSO : BuildingSO
    {
        [SerializeField] private TrainBuilding trainBuilding;

        public TrainBuilding TrainBuilding => trainBuilding;

        public override void Set<T>(T building)
        {
            if (building is TrainBuilding train && building.BuildingType.ToString() == name)
            {
                trainBuilding = train;
            }
        }

        public override Building ToBuilding<T>()
        {
            return trainBuilding;
        }

        public override GameObject GetBuildingPrefab<T>(T building)
        {
            if (building is TrainBuilding buildingToSet)
            {
                return base.GetBuildingPrefab(building);
            }

            return null;
        }
    }
}