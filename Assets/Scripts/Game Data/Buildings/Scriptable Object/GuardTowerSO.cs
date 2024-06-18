using UnityEngine;

namespace RTS.Buildings
{
    [CreateAssetMenu(menuName = "RTS/Building/Guard Tower", fileName = "New Guard Tower")]
    public class GuardTowerSO : BuildingSO
    {
        [SerializeField] private GuardTower guardTower;

        public GuardTower GuardTower => guardTower;

        public override void Set<T>(T building)
        {
            if (building is GuardTower guardTower)
            {
                this.guardTower = guardTower;
            }
        }

        public override Building ToBuilding<T>()
        {
            return guardTower;
        }

        public override GameObject GetBuildingPrefab<T>(T building)
        {
            if (building is GuardTower buildingToSet)
            {
                return base.GetBuildingPrefab(buildingToSet);
            }

            return null;
        }
    }
}