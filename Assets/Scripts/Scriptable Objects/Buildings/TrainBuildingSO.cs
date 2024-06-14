using System.Collections.Generic;
using RTS.Units;
using UnityEngine;

namespace RTS.Buildings
{
    [CreateAssetMenu(menuName = "RTS/Building/Train Building", fileName = "New Train Building")]
    public class TrainBuildingSO : BuildingSO
    {
        [SerializeField] private List<UnitTypeSO> unitsToTrain;

        public List<UnitTypeSO> UnitsToTrain => unitsToTrain;

        public override void Set<T>(T building)
        {
            base.Set(building);

            if (building is TrainBuildingSO train)
            {
                unitsToTrain = train.UnitsToTrain;
            }
        }
    }
}