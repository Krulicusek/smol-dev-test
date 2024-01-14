using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public UpgradeSystem upgradeSystem;
    public SpawnSystem spawnSystem;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            UpgradeTower();
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            UpgradeMinion();
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            IncreaseSpawnRate();
        }
    }

    void UpgradeTower()
    {
        upgradeSystem.UpgradeTower();
    }

    void UpgradeMinion()
    {
        upgradeSystem.UpgradeMinion();
    }

    void IncreaseSpawnRate()
    {
        spawnSystem.IncreaseSpawnRate();
    }
}