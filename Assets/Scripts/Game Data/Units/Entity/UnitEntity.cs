using UnityEngine;

namespace RTS.Units
{
    public class UnitEntity : MonoBehaviour
    {
        [SerializeField] private UnitSO unit;
        [SerializeField] private Sprite icon;

        public Sprite Icon => icon;
        
        private int currentHealth;
        
        public virtual void CommandPrimary() { }
        public virtual void CommandSecondary() { }
        public virtual void CommandHand() { }
    }
}