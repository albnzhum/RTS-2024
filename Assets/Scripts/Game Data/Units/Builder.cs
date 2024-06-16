using System;

namespace RTS.Units
{
    [Serializable]
    public class Builder : Unit
    {
        public float ResourceGatheringSpeed = default;
        public float RepairSpeed = default;
        public int RepairEfficiency = default;

        public Builder(BuilderSO builder) : base(builder)
        {
            ResourceGatheringSpeed = builder.ResourceGatheringSpeed;
            RepairSpeed = builder.RepairSpeed;
            RepairEfficiency = builder.RepairEfficiency;
        }
    }
}