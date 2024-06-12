using System;
using UnityEngine;

public enum Resource
{
    Wood,
    Metal,
    Grain
}

[Serializable]
public class ResourceCost
{
    [SerializeField] private Resource resourceType;
    [SerializeField] private int amount;
}
