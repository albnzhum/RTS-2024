using System;
using UnityEngine;

namespace RTS.Resources.Unit
{
    public class UnitMovementSystem : MonoBehaviour
    {
        [SerializeField] private UnitSelection selection;

        private void Update()
        {
            if (selection.Units.Count != 0)
            {
                foreach (var unit in selection.Units)
                {
                    unit.gameObject.GetComponent<UnitController>().MoveTo(Input.mousePosition);
                }
            }
        }
    }
}