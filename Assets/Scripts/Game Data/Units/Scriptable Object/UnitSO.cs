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

        public abstract Unit ToUnit<T>() where T : Unit;
        
        public virtual GameObject GetUnitPrefab<T>(T unit) where T : Unit
        {
            return UnityEngine.Resources.Load<GameObject>(unit.PrefabName);
        }
    }
}
