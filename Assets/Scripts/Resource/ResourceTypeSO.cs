using UnityEngine;

namespace RTS.Resources
{
    [CreateAssetMenu(menuName = "RTS/Resources/Resource Type", fileName = "New Resource Type")]
    public class ResourceTypeSO : ScriptableObject
    {
        [SerializeField] private Resource resourceType;
        
        public Resource Resource => resourceType;
    }
}