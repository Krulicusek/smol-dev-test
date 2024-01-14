```csharp
using UnityEngine;

public class Minion : MonoBehaviour
{
    public int health;
    public int damage;
    public float speed;
    private UpgradeSystem upgradeSystem;

    void Start()
    {
        upgradeSystem = GameObject.FindObjectOfType<UpgradeSystem>();
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        // Add movement logic here
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        // Add death logic here
    }

    public void Upgrade()
    {
        var upgrade = upgradeSystem.UpgradeMinion();
        health += upgrade.healthIncrease;
        damage += upgrade.damageIncrease;
        speed += upgrade.speedIncrease;
    }
}
```