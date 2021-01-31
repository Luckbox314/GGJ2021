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
    public float mayJump;
    public float soundDelay;
    public Transform spawn;

    private float movX;

    public AudioSource[] sounds;
    public AudioSource jump;
    public AudioSource fall;

    void Start()
    {
        sounds = GetComponents<AudioSource>();
        jump = sounds[0];
        fall = sounds[1];
    }

    private void Update()
    {
        movX = Input.GetAxisRaw("Horizontal");
        IsGrounded();
        
        if (Input.GetKeyDown(KeyCode.W) && mayJump > 0)
        {
            jump.Play();
            Jump();
        }
    }

    private void FixedUpdate()
    {
        mayJump -= Time.deltaTime;
        Vector2 movement = new Vector2(movX * movementSpeed, rb.velocity.y);

        rb.velocity = movement;

        if (IsInside()) {
            rb.transform.position = spawn.position;
        }
    }

    void Jump()
    {
        Vector2 movement = new Vector2(rb.velocity.x, jumpForce);
        rb.velocity = movement;
    }

    public bool IsGrounded()
    {
        Collider2D groundCheck = Physics2D.OverlapCircle(feet.position, 0.2f, groundLayers);

        if (groundCheck != null)
        {
            mayJump = 0.01f;
            return true;
        }

        return false;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (IsGrounded() && soundDelay < 0)
            {
            soundDelay = 0.001f;
            fall.Play();
            soundDelay -= Time.deltaTime;
        }
        else
        {
            soundDelay -= Time.deltaTime;
        }
    }
    public bool IsInside()
    {
        Collider2D hearthCheck = Physics2D.OverlapCircle(rb.transform.position, 0.2f, groundLayers);
        if (hearthCheck != null)
        {
            return true;
        }

        return false;
    }

}
