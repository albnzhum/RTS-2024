using UnityEngine;

namespace RTS.Buildings
{
    [CreateAssetMenu(menuName = "RTS/Building/City Hall", fileName = "New City Hall")]
    public class CityHallSO : BuildingSO
    {
        [SerializeField] private float raduis;
        public float Radius => raduis;

        public override void Set<T>(T building)
        {
            base.Set(building);

            if (building is CityHallSO cityHall)
            {
                raduis = cityHall.Radius;
            }
        }
    }
}