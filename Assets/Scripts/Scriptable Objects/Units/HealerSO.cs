using UnityEngine;

namespace RTS.Units
{
    [CreateAssetMenu(menuName = "RTS/Units/Healer", fileName = "New Healer")]
    public class HealerSO : UnitSO
    {
        [SerializeField] private float minHealDistance = default;
        [SerializeField] private float maxHealDistance = default;
        [SerializeField] private float healDelay = default;
        [SerializeField] private int heal = default;

        public float MinHealDistance => minHealDistance;
        public float MaxHealDistance => maxHealDistance;
        public float HealDelay => healDelay;
        public int Heal => heal;

        protected override void Set<T>(T unit)
        {
            base.Set(unit);

            if (unit is HealerSO healer)
            {
                minHealDistance = healer.MinHealDistance;
                maxHealDistance = healer.MaxHealDistance;
                healDelay = healer.HealDelay;
                heal = healer.Heal;
            }
        }
    }
}