using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementElmar : MonoBehaviour
{
    Vector2 noMov;
    float inputHorizontal;
    float inputVerticale;


    public float moveSpeed = 5f;
    public Rigidbody2D rb;

    public Camera Cam;
    public int health;

    //sprites
    public Sprite FacingUs;
    public Sprite FacingAway;
    public Sprite FacingRight;
    public Sprite FacingLeft;

    private void Start()
    {
        health = 10;
    }

    void Update()
    {
        noMov.x = Input.GetAxisRaw("Horizontal");
        noMov.y = Input.GetAxisRaw("Vertical");
    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + noMov * moveSpeed * Time.fixedDeltaTime);
    }
}