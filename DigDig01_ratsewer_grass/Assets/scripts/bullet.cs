using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public GameObject hitEffect;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        //script som gör att om en enemy blir träffad av bulletsen tar enemyn skada.
<<<<<<< Updated upstream:DigDig01_ratsewer_grass/Assets/scripts/bullet.cs
        var enemy = collision.collider.GetComponent<enemyPlayerBehaviour>();
        if (enemy)
=======
        var BiggieEnemy = collision.collider.GetComponent<EnemyPlayerBehaviour>();
        if (BiggieEnemy)
>>>>>>> Stashed changes:DigDig01_ratsewer_grass/Assets/scripts/Bullet.cs
        {
            BiggieEnemy.Hit(1);
        }

        GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        Destroy(effect, 0.2f);
        Destroy(gameObject);
    }

}
