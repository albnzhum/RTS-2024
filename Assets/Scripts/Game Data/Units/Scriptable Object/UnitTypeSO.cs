using System;
using UnityEngine;

namespace RTS.Units
{
    public enum UnitType
    {
        Archer,
        Lancer,
        Catapult,
        HeavyWarrior,
        Builder,
        Healer,
        Turret
    }
    
    [CreateAssetMenu(menuName = "RTS/Units/Unit Type", fileName = "New Unit Type")]
    public class UnitTypeSO : ScriptableObject
    {
        [SerializeField] private UnitType unitType;

        public UnitType UnitType => unitType;
    }
}