using System;

namespace RTS.Units
{
    [Serializable]
    public class Builder : Unit
    {
        public float ResourceGatheringSpeed = default;
        public float RepairSpeed = default;
        public int RepairEfficiency = default;
    }
}