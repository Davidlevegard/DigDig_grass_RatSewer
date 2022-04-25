using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class collisionController : MonoBehaviour
{
    public healthBarController healthBar;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        //om "enemyProjectile" coliderar med player går healthbaren ner med 1. 
        if (collision.gameObject.tag == "Biggie")
        {
            if (healthBar)
            {
                healthBar.onTakeDamage(1);
            }
        }
        if (collision.gameObject.tag == "Healing")
        {
            if (healthBar)
            {
                healthBar.onTakeHealing(1);
            }
        }

        //om "biggie" coliderar med player går healthbaren ner med 1. 
        //else if (collision.gameObject.tag == "bengtProjectile")
        {
            //if (healthBar)
            {
                //healthBar.onTakeDamage(1);
            }
        }
    }
}