using UnityEngine;

namespace RTS.Buildings
{
    [CreateAssetMenu(menuName = "RTS/Building/Produce Building", fileName = "New Produce Building")]
    public class ProduceBuildingSO : BuildingSO
    {
        [SerializeField] private ProduceBuilding produceBuilding;

        public ProduceBuilding ProduceBuilding => produceBuilding;

        public override void Set<T>(T building)
        {
            if (building is ProduceBuilding produce && building.BuildingType.ToString() == name)
            {
                produceBuilding = produce;
            }
        }
        
        public override Building ToBuilding<T>()
        {
            return produceBuilding;
        }

        public override GameObject GetBuildingPrefab<T>(T building)
        {
            if (building is ProduceBuilding buildingToSet)
            {
                return base.GetBuildingPrefab(buildingToSet);
            }

            return null;
        }
    }
}