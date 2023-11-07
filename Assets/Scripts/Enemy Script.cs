using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public GameObject player;
    public float speed;
    private float distance;
    public Animator animator;
    HelperScript helper;
    bool facingRight;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("idle", true);

        // Add the helper script and store a reference to it                                               
        helper = gameObject.AddComponent<HelperScript>();

        facingRight = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (facingRight)
        {
            speed = 3f;
        }
        else
        {
            speed = -3;
        }

        transform.position = new Vector3( transform.position.x + speed * Time.deltaTime, transform.position.y, transform.position.z );

        distance = player.transform.position.x - transform.position.x;
        
/*        
        if (distance > 0)
        {
            gameObject.transform.localScale = new Vector3(4, 4, 4);
            print("flipped");
        }
        else
        {
            gameObject.transform.localScale = new Vector3(-4, 4, 4);
        }
        if(distance <1 && distance >-1)
        {
            animator.SetTrigger("attack");
            speed = 1;
        }

        if (distance < 7 && distance > -7)
        {
            //transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
            animator.SetBool("walk", true);

        }
        else
        {
            animator.SetBool("walk", false);
        }
*/


        DoEdgeCheck();


    }


    void DoEdgeCheck()
    {
        if (facingRight == false)
        {
            if (helper.DoRayCollisionCheck(Vector2.down, -1.2f, -1.2f) == false)
            {
                facingRight = true;

            }
        }

        if (facingRight == true)
        {

            if (helper.DoRayCollisionCheck(Vector2.down, 1.2f, -1.2f) == false)
            {
                facingRight = false;

            }
        }

    }
}
