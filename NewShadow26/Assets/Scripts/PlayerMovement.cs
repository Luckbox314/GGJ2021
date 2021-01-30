using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed;
    public Rigidbody2D rb;

    public float jumpForce = 10f;
    public Transform feet;
    public LayerMask groundLayers;

    private float movX;

    private void Update()
    {
        movX = Input.GetAxisRaw("Horizontal");
        if (Input.GetKeyDown(KeyCode.W) && IsGrounded())
        {
            Jump();
        }
    }

    private void FixedUpdate()
    {
        Vector2 movement = new Vector2(movX * movementSpeed, rb.velocity.y);

        rb.velocity = movement;
    }

    void Jump()
    {
        Vector2 movement = new Vector2(rb.velocity.x, jumpForce);
        rb.velocity = movement;
    }

    public bool IsGrounded()
    {
        Collider2D groundCheck = Physics2D.OverlapCircle(feet.position, 0.5f, groundLayers);

        if (groundCheck != null)
        {
            return true;
        }

        return false;
    }
}
