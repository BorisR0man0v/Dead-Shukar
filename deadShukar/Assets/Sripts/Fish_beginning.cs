using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish_beginning : MonoBehaviour
{
    private Rigidbody2D rb;
    private float moveSpeed = 10f;
    public Vector2 movement;
    void Start()
    {
       rb = GetComponent<Rigidbody2D>();
        //movement.x = 0.1f;
    }


    public void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed  * Time.fixedDeltaTime);
    }

}
