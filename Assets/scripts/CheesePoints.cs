using UnityEngine.UI;using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheesePoints : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //det h�r scriptet g�r s� att n�r "trash" coliderar med "player f�rsviner det. 
        if (collision.gameObject.tag == "Elmar")
        {
            //detta �r en del av "score scriptet som g�r att n�r "trash coliderar med "player" g�r score up med 1. 
            scoreScript.scoreValue += 1;
            Destroy(gameObject);


        }

    }
}
