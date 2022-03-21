using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firePointController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("A"))
        {
            flip();
        }
    }
    private void flip()
    {

        transform.Rotate(0f, 180f, 0f);
    }
}
