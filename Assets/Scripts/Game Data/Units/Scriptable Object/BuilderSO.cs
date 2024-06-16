using UnityEngine;

namespace RTS.Units
{
    [CreateAssetMenu(menuName = "RTS/Units/Builder", fileName = "New Builder")]
    public class BuilderSO : UnitSO
    {
        [SerializeField] private float resourceGatheringSpeed = default;
        [SerializeField] private float repairSpeed = default;
        [SerializeField] private int repairEfficiency = default;

        public float ResourceGatheringSpeed => resourceGatheringSpeed;
        public float RepairSpeed => repairSpeed;
        public int RepairEfficiency => repairEfficiency;

        public override void Set<T>(T unit)
        {
            base.Set(unit);

            if (unit is Builder builder)
            {
                resourceGatheringSpeed = builder.ResourceGatheringSpeed;
                repairSpeed = builder.RepairSpeed;
                repairEfficiency = builder.RepairEfficiency;
            }
        }

        public override Unit ToUnit<T>()
        {
            return new Builder(this);
        }
    }
}