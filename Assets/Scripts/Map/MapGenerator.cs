using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    
    
    private void ClearAreaAroundBase(Vector3 position, float radius)
    {
        Collider[] colliders = Physics.OverlapSphere(position, radius);
        foreach (Collider collider in colliders)
        {
            if (collider.gameObject.CompareTag("Resource"))
            {
                Destroy(collider.gameObject);
            }
        }
    }
}
