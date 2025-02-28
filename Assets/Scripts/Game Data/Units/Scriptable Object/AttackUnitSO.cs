using UnityEngine;

namespace RTS.Units
{
    [CreateAssetMenu(menuName = "RTS/Units/Attack Unit", fileName = "New Attack Unit")]
    public class AttackUnitSO : UnitSO
    {
        [SerializeField] private AttackUnit attackUnit;
        public AttackUnit AttackUnit => attackUnit;

        public override void Set<T>(T unit)
        {
            if (unit is AttackUnit attackUnit && unit.UnitType.ToString() == name)
            {
                this.attackUnit = attackUnit;
            }
        }

        public override Unit ToUnit()
        {
            return attackUnit;
        }
    }
}
