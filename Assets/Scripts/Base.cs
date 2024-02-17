using UnityEngine;

public class Base : MonoBehaviour
{
    public int baseHP;
    public Vector2 basePosition;

    void Start()
    {
        baseHP = (int)transform.localScale.x;
        basePosition = transform.position;
    }

    void Update()
    {
        if (baseHP <= 0)
        {
            GameManager.instance.GameOver();
        }
    }

    public void TakeDamage(int damage)
    {
        baseHP -= damage;
        if (baseHP < 0)
        {
            baseHP = 0;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Projectile"))
        {
            Projectile projectile = other.gameObject.GetComponent<Projectile>();
            TakeDamage(projectile.damage);
            Destroy(other.gameObject);
        }
    }
}