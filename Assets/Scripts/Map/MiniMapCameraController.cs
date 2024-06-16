using UnityEngine;

public class MiniMapCameraController : MonoBehaviour
{
    [SerializeField] private Terrain terrain; 
    
    private Camera miniMapCamera;

    void Start()
    {
        miniMapCamera = GetComponent<Camera>();
        AdjustCamera();
    }

    void AdjustCamera()
    {
        if (terrain != null)
        {
            Vector3 terrainSize = terrain.terrainData.size;

            transform.position = new Vector3(terrainSize.x / 2, transform.position.y, terrainSize.z / 2);
            
            miniMapCamera.orthographicSize = Mathf.Max(terrainSize.x, terrainSize.z) / 2;
            miniMapCamera.aspect = terrainSize.x / terrainSize.z;
        }
    }
}
