using System.Collections.Generic;
using RTS.Resources;
using UnityEngine;

namespace RTS.Buildings
{
    [CreateAssetMenu(menuName = "RTS/Building/Produce Building", fileName = "New Produce Building")]
    public class ProduceBuildingSO : BuildingSO
    {
        [SerializeField] private List<ResourceTypeSO> resourcesToProduce;

        public List<ResourceTypeSO> ResourceToProduce => resourcesToProduce;

        public override void Set<T>(T building)
        {
            base.Set(building);

            if (building is ProduceBuildingSO produce)
            {
                resourcesToProduce = produce.resourcesToProduce;
            }
        }
    }
}