using UnityEngine.UI;using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheesePoints : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //det här scriptet gör så att när "trash" coliderar med "player försviner det. 
        if (collision.gameObject.tag == "Elmar")
        {
            //detta är en del av "score scriptet som gör att när "trash coliderar med "player" går score up med 1. 
            scoreScript.scoreValue += 1;
            Destroy(gameObject);


        }

    }
}
