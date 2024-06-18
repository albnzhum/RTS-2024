using System;
using System.Collections.Generic;
using RTS.Units;

namespace RTS.Buildings
{
    [Serializable]
    public class TrainBuilding : Building
    {
        public List<UnitType> UnitsToTrain;
    }
}