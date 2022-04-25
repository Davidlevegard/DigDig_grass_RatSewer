using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restartmaneger : MonoBehaviour
{


    void Start()
    {

    }

    void Update()
    {

    }

    public void resetscene()
    {
        //ScoreScript.scoreValue = 0;
        SceneManager.LoadScene("SampleScene");
    }
}
