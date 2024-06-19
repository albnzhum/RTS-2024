using UnityEngine;

namespace RTS.Units
{
    public abstract class UnitSO : ScriptableObject
    {
        [SerializeField] protected Unit unit = default;
        public Unit Unit => unit;

        public virtual void Set<T>(T unitToSet) where T : Unit
        {
            unit = unitToSet;
        }

        public abstract Unit ToUnit();
        
    }
}
