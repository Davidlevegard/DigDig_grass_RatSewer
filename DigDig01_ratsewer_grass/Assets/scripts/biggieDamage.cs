using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class biggieDamage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //this script makes it so on impact the players health goes down "1" untill it hits 0 health whitch then makes it so the player
        //gets destroyed. 
        if (collision.gameObject.tag == "elmar")
        {
            int newHealth = collision.gameObject.GetComponent<movementElmar>().health;
            if (newHealth > 1)
            {
                //om Newhealth �r h�gre en 1 g�r siffran ner med 1 tills den n�r 0. 
                collision.gameObject.GetComponent<movementElmar>().health--;
            }
            else
            {
                //om NewHealth �r mindre en 1 f�rst�rs objecktet och "gameOverScenen" vissas. 
                Destroy(collision.gameObject);
                //SceneManager.LoadScene("GameOverScene");

            }
        }
    }
}