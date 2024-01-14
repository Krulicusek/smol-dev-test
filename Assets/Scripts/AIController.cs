using System.Collections;
using UnityEngine;

public class AIController : MonoBehaviour
{
    public GameObject minionPrefab;
    private SpawnSystem spawnSystem;

    private void Start()
    {
        spawnSystem = GetComponent<SpawnSystem>();
    }

    private void Update()
    {
        if (ShouldSpawnMinion())
        {
            SpawnMinion();
        }
    }

    private bool ShouldSpawnMinion()
    {
        // Implement AI logic here to decide when to spawn minions
        // This could be based on game time, player's strength, AI's current resources, etc.
        return true;
    }

    private void SpawnMinion()
    {
        spawnSystem.SpawnMinion(minionPrefab);
    }
}