using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreScript : MonoBehaviour
{
    //detta scriptet g�r s� att n�r "player" coliderar med "trash" g�r score up med 1. 
    public static int scoreValue = 0;
    Text Score;

    // Start is called before the first frame update
    void Start()
    {
        scoreValue = 0;
        Score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Score.text = "chese: " + scoreValue;
    }

}

