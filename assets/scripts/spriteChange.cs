using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spriteChange : MonoBehaviour
{
    public GameObject Player;

    public Sprite FacingUs;
    public Sprite FacingAway;
    public Sprite FacingRight;
    public Sprite FacingLeft;

    bool turnedLeft = false;

    void Update()
    {
        if (Input.GetButtonDown("W"))
        {
            this.GetComponent<SpriteRenderer>().sprite = FacingAway;
        }
        /*if (Input.GetButtonDown("A"))
        {
            this.GetComponent<SpriteRenderer>().sprite = FacingLeft;
        }*/
        else if(Input.GetButtonDown("S"))
        {
            this.GetComponent<SpriteRenderer>().sprite = FacingUs;
        }
        /*if (Input.GetButtonDown("D"))
        {
            this.GetComponent<SpriteRenderer>().sprite = FacingRight;
        }*/
        else if (Input.GetButtonDown("D"))
        {
            this.GetComponent<SpriteRenderer>().sprite = FacingRight;
            
            if (turnedLeft == true)
            {

                
                flip();
                turnedLeft = false;
            }
            
            
        }

        else if (Input.GetButtonDown("A"))
        {
            this.GetComponent<SpriteRenderer>().sprite = FacingRight;
            if (turnedLeft == false)
            {
                

                flip();
                turnedLeft = true;
            }
            
            
        } 

    }
    private void flip()
    {
        transform.Rotate(0f, 180f, 0f);
    }
    private void moveFirePointLeft()
    {
        //this.transform.position = new Vector3(100f, 0f, 0f);*
        transform.Rotate(0f, 180f, 0f);
    }
}

