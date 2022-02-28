using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementElmar : MonoBehaviour
{
    Vector2 noMov;

    public float moveSpeed = 5f;
    public Rigidbody2D rb;

    public Camera Cam;


    void Start()
    {

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
