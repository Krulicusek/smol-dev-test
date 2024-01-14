```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSystem : MonoBehaviour
{
    public GameObject minionPrefab;
    public Transform[] spawnPoints;
    private float spawnRate = 5f;
    private float nextSpawnTime = 0f;

    void Update()
    {
        if (ShouldSpawn())
        {
            SpawnMinion();
        }
    }

    private bool ShouldSpawn()
    {
        return Time.time >= nextSpawnTime;
    }

    private void SpawnMinion()
    {
        nextSpawnTime = Time.time + spawnRate;
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        Instantiate(minionPrefab, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    }

    public void IncreaseSpawnRate()
    {
        if(spawnRate > 1)
        {
            spawnRate--;
        }
    }
}
```