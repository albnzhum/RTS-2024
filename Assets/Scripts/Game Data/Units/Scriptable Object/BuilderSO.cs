using UnityEngine;

namespace RTS.Units
{
    [CreateAssetMenu(menuName = "RTS/Units/Builder", fileName = "New Builder")]
    public class BuilderSO : UnitSO
    {
        [SerializeField] private Builder builder;

        public Builder Builder => builder;

        public override void Set<T>(T unit)
        {
            if (unit is Builder builder)
            {
                this.builder = builder;
            }
        }

        public override Unit ToUnit<T>()
        {
            return builder;
        }

        public override GameObject GetUnitPrefab<T>(T unit)
        {
            if (unit is Builder builder)
            {
                return base.GetUnitPrefab(builder);
            }

            return null;
        }
    }
}