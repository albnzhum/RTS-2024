using UnityEngine;

namespace RTS.Units
{
    [CreateAssetMenu(menuName = "RTS/Units/Turret", fileName = "New Turrer")]
    public class TurretSO : UnitSO
    {
        [SerializeField] private Turret turret;
        public Turret Turret => turret;

        public override void Set<T>(T unit)
        {
            if (unit is Turret turretToSet)
            {
                turret = turretToSet;
            }
        }

        public override Unit ToUnit<T>()
        {
            return turret;
        }

        public override GameObject GetUnitPrefab<T>(T unit)
        {
            if (unit is Turret Turret)
            {
                return base.GetUnitPrefab(Turret);
            }

            return null;
        }
    }
}