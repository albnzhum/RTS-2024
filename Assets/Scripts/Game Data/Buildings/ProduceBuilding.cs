using System;
using System.Collections.Generic;
using RTS.Resources;

namespace RTS.Buildings
{
    [Serializable]
    public class ProduceBuilding : Building
    {
        public List<Resource> ResourceToProduce;
    }
}