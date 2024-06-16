using RTS.UI;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    [SerializeField] private float noiseScale = 20f;

    [SerializeField] private GameObject rockPrefab;
    [SerializeField] private GameObject treePrefab;
    [SerializeField] private GameObject townHallPrefab;

    [SerializeField] private GameSettingsSO gameSettings;

    private Terrain _terrain;
    private TerrainData _terrainData;

    private int _terrainSize;

    private void Start()
    {
        _terrainSize = gameSettings.MapSize;
        
        GenerateResources();
        PlaceBases();
    }

    private void GenerateResources()
    {
        float offsetX = Random.Range(0f, 99999f);
        float offsetY = Random.Range(0f, 99999f);

        for (int x = 0; x < _terrainSize *2; x += 10)
        {
            for (int z = 0; z < _terrainSize *2; z += 10)
            {
                float xCoord = offsetX + (float)x / _terrainSize * noiseScale;
                float zCoord = offsetY + (float)z / _terrainSize * noiseScale;
                float sample = Mathf.PerlinNoise(xCoord, zCoord);

                if (sample > 0.5f)
                {
                    Instantiate(rockPrefab, new Vector3(x, 0, z), Quaternion.identity);
                }
                else if (sample > 0.3f)
                {
                    Instantiate(treePrefab, new Vector3(x, 0, z), Quaternion.identity);
                }
            }
        }
    }

    private void PlaceBases()
    {
        Vector3[] basePositions = { new Vector3(50, 0, 50), new Vector3(_terrainSize - 50, 0, _terrainSize - 50) };

        for (int i = 0; i < basePositions.Length; i++)
        {
            Vector3 basePosition = basePositions[i];
            GameObject townHall = Instantiate(townHallPrefab, basePosition, Quaternion.identity);

            // Clear area around base
            ClearAreaAroundBase(basePosition, 30);
        }
    }
    
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
