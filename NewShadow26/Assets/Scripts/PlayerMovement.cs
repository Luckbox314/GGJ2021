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
    public Animator animator;
    private bool facingRight = true;

    private float movX;

    public AudioSource jump;

    void Start()
    {
        jump = GetComponent<AudioSource>();
    }

    private void Update()
    {
        movX = Input.GetAxisRaw("Horizontal");
        IsGrounded();

        if (rb.velocity.x >= 0.1f) { facingRight = true; }
        else if (rb.velocity.x <= -0.1f) { facingRight = false; }


        if (Input.GetKeyDown(KeyCode.W) && mayJump > 0)
        {
            PlayJump();
            Jump();
        }

        animator.SetFloat("speedX", Mathf.Abs(rb.velocity.x));
        animator.SetFloat("speedY", rb.velocity.y);
        animator.SetBool("air", !IsGrounded());
    }

    private void FixedUpdate()
    {
        mayJump -= Time.deltaTime;
        Vector2 movement = new Vector2(movX * movementSpeed, rb.velocity.y);

        if (facingRight) { gameObject.transform.localScale = new Vector3(0.75f, 0.75f, 1);  }
        if (!facingRight) { gameObject.transform.localScale = new Vector3(-0.75f, 0.75f, 1); }

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

    public void PlayJump()
    {
        jump.Play();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (IsGrounded() && soundDelay < 0)
            {
            soundDelay = 0.001f;
            PlayJump();
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
