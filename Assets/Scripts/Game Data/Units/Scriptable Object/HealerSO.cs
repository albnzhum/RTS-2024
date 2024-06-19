using UnityEngine;

namespace RTS.Units
{
    [CreateAssetMenu(menuName = "RTS/Units/Healer", fileName = "New Healer")]
    public class HealerSO : UnitSO
    {
        [SerializeField] private Healer healer;

        public Healer Healer => healer;

        public override void Set<T>(T unit)
        {
            if (unit is Healer healer)
            {
                this.healer = healer;
            }
        }

        public override Unit ToUnit()
        {
            return healer;
        }
        
    }
}