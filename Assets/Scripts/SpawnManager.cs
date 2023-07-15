using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] ObstaclePrefabs;
    private float spawnRangeX = 10;
    public float spawnRangeY = 20;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", 2 , 3.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnRandomAnimal()
    {
        int ObstacleIndex = Random.Range(0, ObstaclePrefabs.Length);
        Vector3 position = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), spawnRangeY , 0);

        Instantiate(ObstaclePrefabs[ObstacleIndex], position , ObstaclePrefabs[ObstacleIndex].transform.rotation );
    }
}
