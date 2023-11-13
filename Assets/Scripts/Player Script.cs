using UnityEngine;


public class PlayerScript : MonoBehaviour
{
    float speed = 1f;
    private Rigidbody2D player;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask groundLayer;
    private bool isTouchingGround;
    Rigidbody2D rb;
    public Animator animator;
    private SpriteRenderer spriteRenderer;
    HelperScript helper;
    int moving;
    public Transform Teleport;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("idle", true);
        player = GetComponent<Rigidbody2D>();
        rb = GetComponent<Rigidbody2D>();

        // Add the helper script and store a reference to it                                               
        helper = gameObject.AddComponent<HelperScript>();






    }

    // Update is called once per frame
    void Update()
    {
        isTouchingGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
        //run
        if (Input.GetKey("left shift") == true && moving ==1)
        {
            print("player pressed shift");
           
            speed = 4f;
            animator.SetBool("run", true);
            animator.SetBool("walk", false);    
            animator.SetBool("idle", false) ;
        }
        else
        {
            speed = 1f;
            animator.SetBool("run", false);
        }

        //left
        if (Input.GetKey("a") == true)
        {
            print("player pressed left");
            transform.position = new Vector2(transform.position.x - (1*speed *Time.deltaTime), transform.position.y);
            animator.SetBool("walk", true);
            helper.FlipSprite(true);
            moving = 1;
            
        }
        //right
        else if (Input.GetKey("d") == true)
        {
            print("player pressed right");
            transform.position = new Vector2((1 * speed *Time.deltaTime) + transform.position.x, transform.position.y);
            animator.SetBool("walk", true);
            helper.FlipSprite(false);
            moving = 1;

        }
        else
        {
            animator.SetBool("walk",false);
            moving = 0;
        }
   
        //jump
        print("isgrounded=" + isTouchingGround);
        if (Input.GetKeyDown("space") && isTouchingGround)
        {
            rb.AddForce(new Vector3(0, 4, 0), ForceMode2D.Impulse);
            animator.SetBool("jump", true);

        }
        else
        {
            animator.SetBool("jump", false);
        }
        //attack
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            animator.SetTrigger("attack");
        }


  
       
    }
    
}
