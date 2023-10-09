using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public GameObject player;
    public float speed;
    private float distance;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("idle", true);
    }

    // Update is called once per frame
    void Update()
    {
        speed = 1.5f;
        distance = player.transform.position.x - transform.position.x;
        
        if (distance > 0)
        {
            gameObject.transform.localScale = new Vector3(2, 2, 2);
            print("flipped");
        }
        else
        {
            gameObject.transform.localScale = new Vector3(-2, 2, 2);
        }
        if(distance <1 && distance >-1)
        {
            animator.SetTrigger("attack");
            speed = 1;
        }

        if (distance < 4 && distance > -4)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
            animator.SetBool("walk", true);

        }
        else
        {
            animator.SetBool("walk", false);
        }


    }
}
