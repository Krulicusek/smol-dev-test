using UnityEngine;

public class Health : MonoBehaviour
{
    public int baseHP;

    void Start()
    {
        baseHP = (int)transform.localScale.x;
    }

    public void TakeDamage(int damage)
    {
        baseHP -= damage;

        if (baseHP <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
        GameManager.instance.GameOver();
    }
}