using System;
using System.Collections.Generic;
using RTS.UI;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    [Header("Prefabs")]
    [SerializeField] private GameObject rockPrefab;
    [SerializeField] private GameObject treePrefab;
    [SerializeField] private GameObject townHallPrefab;

    [Header("Core")] 
    [SerializeField] private Transform parent;
    [SerializeField] private GameSettingsSO gameSettings;
    
    private int _terrainSize;

    private Vector3 center;

    private Vector3[] corners = new Vector3[4];

    private void Start()
    {
        _terrainSize = gameSettings.MapSize * 2;

        center = new Vector3(_terrainSize / 2, 0, _terrainSize /2);

        corners = new[]
        {
            Vector3.zero,
            new Vector3(0, 0, _terrainSize),
            new Vector3(_terrainSize, 0, 0),
            new Vector3(_terrainSize, 0, _terrainSize)
        };
        
        
        GenerateResources();
        PlaceBases();
    }

    private List<Vector3> DivideTerrainByFourParts()
    {
        List<Vector3> positions = new List<Vector3>();

        foreach (var corner in corners)
        {
            Vector3 position = GetMidpoint(corner, center);
            positions.Add(position);
        }

        return positions;
    }

    private List<Vector3> DivideTerrainBySixParts()
    {
        List<Vector3> positions = new List<Vector3>();

        float sectionWidth = _terrainSize / 3f;
        float sectionHeight = _terrainSize / 2f;

        for (int x = 0; x < 3; x++)
        {
            for (int y = 0; y < 2; y++)
            {
                Vector3 position = new Vector3(
                    sectionWidth * (x + 0.5f),
                    0,
                    sectionHeight * (y + 0.5f) 
                );
                positions.Add(position);
            }
        }

        return positions;
    }

    private List<Vector3> DivideTerrainByNineParts()
    {
        List<Vector3> positions = new List<Vector3>();

        float sectionWidth = _terrainSize / 3f;
        float sectionHeight = _terrainSize / 3f;

        for (int x = 0; x < 3; x++)
        {
            for (int y = 0; y < 3; y++)
            {
                if (x == 1 && y == 1)
                    continue;
                
                Vector3 position = new Vector3(
                    sectionWidth * (x + 0.5f),
                    0,
                    sectionHeight * (y + 0.5f) 
                );
                positions.Add(position);
            }
        }

        return positions;
    }
    
    private Vector3 GetMidpoint(Vector3 point1, Vector3 point2)
    {
        return new Vector3(
            (point1.x + point2.x) / 2,
            (point1.y + point2.y) / 2,
            (point1.z + point2.z) / 2
        );
    }

    void GenerateResources()
    {
        for (int x = 0; x < _terrainSize; x++)
        {
            for (int y = 0; y < _terrainSize ; y++)
            {
                float xCoord = (float)x / _terrainSize * 40;
                float yCoord = (float)y / _terrainSize * 40;
                float sample = Mathf.PerlinNoise(xCoord, yCoord);

                if (sample > 0.8f)
                {
                    Vector3 position = new Vector3(x, 0, y);
                    GameObject resourcePrefab = (sample > 0.85f) ? rockPrefab : treePrefab;
                    Instantiate(resourcePrefab, position, Quaternion.identity, parent);
                }
            }
        }
    }

    private void PlaceBases()
    {
        int playersCount = gameSettings.Players.Count;
        List<Vector3> basePositions = new List<Vector3>();
        
        if (playersCount <= 4)
        {
            basePositions = DivideTerrainByFourParts();
        }
        else if (playersCount <= 6)
        {
            basePositions = DivideTerrainBySixParts();
        }
        else if (playersCount == 7)
        {
            basePositions = DivideTerrainByNineParts();
        }

        System.Random rand = new System.Random();

        for (int i = 0; i < playersCount; i++)
        {
            int position = rand.Next(0, basePositions.Count);
        
            Vector3 basePosition = basePositions[position];
            basePositions.RemoveAt(position);
            GameObject townHall = Instantiate(townHallPrefab, basePosition, Quaternion.identity);
            townHall.GetComponent<FactionSlot>().CurrentPlayer = gameSettings.Players[i].Player;

            ClearAreaAroundBase(basePosition, 30);
        }
    }

    private void ClearAreaAroundBase(Vector3 position, float radius)
    {
        var size = Physics.OverlapSphere(position, radius);
        foreach (Collider collider in size)
        {
            if (collider.gameObject.CompareTag("Resource"))
            {
                Destroy(collider.gameObject);
            }
        }
    }
}
