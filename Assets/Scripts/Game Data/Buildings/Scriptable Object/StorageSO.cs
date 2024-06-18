using UnityEngine;

namespace RTS.Buildings
{
    [CreateAssetMenu(menuName = "RTS/Building/Storage", fileName = "New Storage")]
    public class StorageSO : BuildingSO
    {
        [SerializeField] private Storage storage;

        public Storage Storage => storage;

        public override void Set<T>(T building)
        {
            if (building is Storage buildingToSet)
            {
                storage = buildingToSet;
            }
        }

        public override Building ToBuilding<T>()
        {
            return storage;
        }
        
        public override GameObject GetBuildingPrefab<T>(T building)
        {
            if (building is Storage buildingToSet)
            {
                return base.GetBuildingPrefab(buildingToSet);
            }

            return null;
        }
    }
}