using System;
using UnityEngine;

namespace RTS.Resources
{
    public enum Resource
    {
        Wood,
        Metal,
        Grain,
        Food,
        UnitCount,
        Stone
    }

    [Serializable]
    public class ResourceCost
    {
        [SerializeField] private Resource resourceType;
        [SerializeField] private int amount;

        public Resource Resource => resourceType;
        public int Amount => amount;
    }
}