using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class biggieDamage : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //this script makes it so on impact the players health goes down "1" untill it hits 0 health whitch then makes it so the player
        //gets destroyed. 
        if (collision.gameObject.tag == "Elmar")
        {
            int newHealth = collision.gameObject.GetComponent<movementElmar>().health;
            if (newHealth > 1)
            {
                //om Newhealth är högre en 1 går siffran ner med 1 tills den når 0. 
                collision.gameObject.GetComponent<movementElmar>().health--;
            }
            else
            {
                //om NewHealth är mindre en 1 förstörs objecktet och "gameOverScenen" vissas. 
                Destroy(collision.gameObject);

                SceneManager.LoadScene("GameOver screen");

            }
        }
    }
}