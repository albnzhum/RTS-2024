using UnityEngine;
using UnityEngine.Events;

namespace RTS.Events
{
    [CreateAssetMenu(menuName = "RTS/Events/VoidEventChannel", fileName = "New Void Event Channel")]
    public class VoidEventChannelSO : ScriptableObject
    {
        public event UnityAction OnEventRaised;

        public void RaiseEvent()
        {
            if (OnEventRaised != null)
            {
                OnEventRaised.Invoke();
            }
            else
            {
                Debug.LogError("There is no subscribers");
            }
        }
    }
}
