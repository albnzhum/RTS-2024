using System;

namespace RTS.Units
{
    [Serializable]
    public class Healer : Unit
    {
        public float MinHealDistance = default;
        public float MaxHealDistance = default;
        public float HealDelay = default;
        public int Heal = default;
    }
}