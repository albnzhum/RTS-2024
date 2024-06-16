using UnityEngine;

namespace RTS.Buildings
{
    [CreateAssetMenu(menuName = "RTS/Building/Storage", fileName = "New Storage")]
    public class StorageSO : BuildingSO
    {
        [SerializeField] private int valueToIncreaseResource;
        public int ValueToIncreaseResource => valueToIncreaseResource;

        public override void Set<T>(T building)
        {
            base.Set(building);

            if (building is StorageSO storage)
            {
                valueToIncreaseResource = storage.ValueToIncreaseResource;
            }
        }
    }
}