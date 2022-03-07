using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementElmar : MonoBehaviour
{
    Vector2 noMov;
    float inputHorizontal;
    float inputVerticale;

    public float moveSpeed = 5f;
    public Rigidbody2D rb;

    public Camera Cam;
    public int health;


    private void Start()
    {
        health = 5;
    }

    void Update()
    {
        noMov.x = Input.GetAxisRaw("Horizontal");
        noMov.y = Input.GetAxisRaw("Vertical");
    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + noMov * moveSpeed * Time.fixedDeltaTime);

        if(inputHorizontal > 0)
        {
            rb.AddForce(new Vector2(inputHorizontal * moveSpeed, 0f));
        }
    }
}
