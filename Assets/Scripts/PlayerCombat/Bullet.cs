using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;

    public int damage = 50;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;

        Destroy(gameObject, 2);
    }

    void OnTriggerEnter2D (Collider2D hitInfo)
    {
        ThingEnemy thingEnemy = hitInfo.GetComponent<ThingEnemy>();

        if (thingEnemy != null)
        {
            thingEnemy.TakeDamage(damage);
        }

        Destroy(gameObject);
    }

}
