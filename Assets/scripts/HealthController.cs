using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //this script makes it so on impact the players health goes down "1" untill it hits 0 health whitch then makes it so the player
        //gets destroyed. 
        if (collision.gameObject.tag == "Elmar")
        {
            int newHealth = collision.gameObject.GetComponent<movementElmar>().health;
            if (newHealth < 10)
            {
                //om Newhealth �r h�gre en 1 g�r siffran ner med 1 tills den n�r 0. 
                newHealth = collision.gameObject.GetComponent<movementElmar>().health + 1;
            }
        }
    }
}
