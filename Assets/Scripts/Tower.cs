```csharp
using UnityEngine;

public class Tower : MonoBehaviour
{
    public int level = 1;
    public int damage = 10;
    public float attackSpeed = 1f;
    private float attackTimer = 0f;

    private void Update()
    {
        attackTimer += Time.deltaTime;
        if (attackTimer >= attackSpeed)
        {
            Attack();
            attackTimer = 0f;
        }
    }

    private void Attack()
    {
        // Implement attack logic here
    }

    public void Upgrade()
    {
        level++;
        damage += 5;
        attackSpeed *= 0.9f;
    }
}
```