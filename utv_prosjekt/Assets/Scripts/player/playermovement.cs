using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public float moveSpeed;

    public Rigidbody2D rb;

    private Vector2 moveDirection;

    // Update is called once per frame
    // Denne er ikke egnet for bevegelse da den oppdateres hver frame
    // så denne bruker jeg til input registrering.
    void Update()
    {
        ProcessInputs();
    }


    // Denne oppdateres en bestemt mengde og blir brukt for bevegelse
    // slik at fps ikke kan påvirke farten
    void FixedUpdate() 
    {
        Move();
    }


    void ProcessInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(moveX, moveY).normalized;

        if (Input.GetKey (KeyCode.LeftShift))
        {
            moveSpeed = 3;
        }
        else
        {
            moveSpeed = 5;
        }

    }


    void Move()
    {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }
}
