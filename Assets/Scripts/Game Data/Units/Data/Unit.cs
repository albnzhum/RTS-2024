using System.Collections.Generic;
using System.Runtime.Serialization;
using RTS.Resources;
using UnityEngine;

namespace RTS.Units
{
    [DataContract]
    public class Unit
    {
        [DataMember] public string Name;
        [DataMember] public string PrefabName;
        [DataMember] public UnitType UnitType;
        [DataMember] public float MovementSpeed;
        [DataMember] public int Health;
        [DataMember] public List<ResourceCost> ResourceCost;
        [DataMember] public float DetectionRange;
    }
}