using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChange : MonoBehaviour
{
    public GameObject Player;

    public Sprite FacingUs;
    public Sprite FacingAway;
    public Sprite FacingRight;
    public Sprite FacingLeft;

    void Update()
    {
        if (Input.GetButtonDown("W"))
        {
            this.GetComponent<SpriteRenderer>().sprite = FacingUs;
        }

        if (Input.GetButtonDown("A"))
        {
            this.GetComponent<SpriteRenderer>().sprite = FacingLeft;
        }
        if (Input.GetButtonDown("S"))
        {
            this.GetComponent<SpriteRenderer>().sprite = FacingAway;
        }
        if (Input.GetButtonDown("D"))
        {
            this.GetComponent<SpriteRenderer>().sprite = FacingRight;
        }
    }
}
