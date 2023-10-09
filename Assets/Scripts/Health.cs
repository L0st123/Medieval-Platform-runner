using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth = 10;
    public int currentHealth;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void TakeDamage(int amount)
    {
        currentHealth -= amount;

        if (currentHealth <=0)
        {
            animator.SetBool("dead", true);
        }
        else
        {
            animator.SetBool("dead", false);
        }

    }
}

