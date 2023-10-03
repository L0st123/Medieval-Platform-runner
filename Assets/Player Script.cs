using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerScript : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D player;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask groundLayer;
    private bool isTouchingGround;
    Rigidbody2D rb;
    public Animator animator;
    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("idle", true);
        player = GetComponent<Rigidbody2D>();
        rb = GetComponent<Rigidbody2D>();





    }

    // Update is called once per frame
    void Update()
    {
        isTouchingGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);

        float speed = 1f;
        //left
        if (Input.GetKey("a") == true)
        {
            print("player pressed left");
            transform.position = new Vector2(transform.position.x - (1*speed *Time.deltaTime), transform.position.y);
            animator.SetBool("walk", true);
            gameObject.transform.localScale = new Vector3(-2, 2, 2);




        }
        //right
        else if (Input.GetKey("d") == true)
        {
            print("player pressed right");
            transform.position = new Vector2((1 * speed *Time.deltaTime) + transform.position.x, transform.position.y);
            animator.SetBool("walk", true);
            gameObject.transform.localScale = new Vector3(2, 2, 2);


        }
        else
        {
            animator.SetBool("walk", false);
        }

        print("isgrounded=" + isTouchingGround);
        if (Input.GetKeyDown("w") && isTouchingGround)
        {
            rb.AddForce(new Vector3(0, 4, 0), ForceMode2D.Impulse);
            animator.SetBool("jump", true);

        }
        else
        {
            animator.SetBool("jump", false);
        }
    }
}
