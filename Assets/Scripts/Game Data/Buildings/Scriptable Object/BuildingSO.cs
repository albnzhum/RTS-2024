using System;
using UnityEngine;

namespace RTS.Buildings
{
    [Serializable]
    public abstract class BuildingSO : ScriptableObject
    {
        [SerializeField] private Building building;
        public Building Building => building;

        public virtual void Set<T>(T building) where T : Building
        {
            this.building = building;
        }

        public abstract Building ToBuilding<T>() where T : Building;
        
        public virtual GameObject GetBuildingPrefab<T>(T building) where T : Building
        {
            return UnityEngine.Resources.Load<GameObject>(building.Prefab);
        }
    }
}