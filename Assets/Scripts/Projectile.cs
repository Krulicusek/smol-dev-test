using System.Collections;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float projectileSpeed;
    private Vector2 target;

    void Start()
    {
        target = GameObject.Find("Base").transform.position;
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, projectileSpeed * Time.deltaTime);

        if (Vector2.Distance(transform.position, target) < 0.2f)
        {
            DestroyProjectile();
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Wall"))
        {
            DestroyProjectile();
        }
    }

    void DestroyProjectile()
    {
        Destroy(gameObject);
    }
}