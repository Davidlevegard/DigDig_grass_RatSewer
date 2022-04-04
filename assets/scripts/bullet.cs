using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed = 15f;
    public GameObject hitEffect;
    public Rigidbody2D rb;

    private void Start()
    {
        rb.velocity = transform.right * speed;
        Destroy(gameObject, 10f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //script som g�r att om en enemy blir tr�ffad av bulletsen tar enemyn skada.
        var enemy = collision.collider.GetComponent<enemyPlayerBehaviour>();
        if (enemy)
        {
            enemy.Hit(1);
        }

        GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        Destroy(effect, 0.2f);
        Destroy(gameObject);
    }
}
