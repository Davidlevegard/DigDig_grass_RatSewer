using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public GameObject hitEffect;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        //script som g�r att om en enemy blir tr�ffad av bulletsen tar enemyn skada.
        var enemy = collision.collider.GetComponent<enemyPlayerBehaviour>();
        if (enemy)
        {
            var biggieEnemy = collision.collider.GetComponent<enemyPlayerBehaviour>();
        }

        if (biggieEnemy)
        {
            biggieEnemy.Hit(1);
        }

        GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        Destroy(effect, 0.2f);
        Destroy(gameObject);
    }

}
