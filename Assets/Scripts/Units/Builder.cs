using System;
using UnityEngine;

namespace RTS.Units
{
    [Serializable]
    public class Builder: Unit
    {
        [SerializeField] private float resourceGatheringSpeed;
        [SerializeField] private float repairSpeed;
        [SerializeField] private int repairEfficiency;

        public float ResourceGatheringSpeed => resourceGatheringSpeed;
        public float RepairSpeed => repairSpeed;
        public int RepairEfficiency => repairEfficiency;
    }
}