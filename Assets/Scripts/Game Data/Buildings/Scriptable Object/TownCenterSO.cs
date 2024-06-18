using UnityEngine;

namespace RTS.Buildings
{
    [CreateAssetMenu(menuName = "RTS/Building/City Hall", fileName = "New City Hall")]
    public class TownCenterSO : BuildingSO
    {
        [SerializeField] private TownCenter townCenter;
        public TownCenter TownCenter => townCenter;

        public override void Set<T>(T building)
        {
            if (building is TownCenter cityHall)
            {
                townCenter = cityHall;
            }
        }
        
        public override Building ToBuilding<T>()
        {
            return townCenter;
        }

        public override GameObject GetBuildingPrefab<T>(T building)
        {
            if (building is TownCenter center)
            {
                return base.GetBuildingPrefab(center);
            }

            return null;
        }
    }
}