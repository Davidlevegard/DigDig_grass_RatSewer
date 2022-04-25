using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level1toLvl2 : MonoBehaviour
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
        if (collision.gameObject.tag == "Elmar")
        {
            SceneManager.LoadScene("lvl02");
        }
    }
}
