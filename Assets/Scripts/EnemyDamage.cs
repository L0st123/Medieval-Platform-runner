using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public int damage= 1;
    public Animator animator;
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask playerLayers;
    public int attackDamage = 2;
    float nextAttackTime = 0f;
    public float AttackRate = 1f;
    private float distance;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distance = player.transform.position.x - transform.position.x;

        if (Time.time >= nextAttackTime)
        {
            if (distance < 1 && distance > -1)
            {
                Attack();
                nextAttackTime = Time.time + 1f / AttackRate;
            }
        }
    }
    void Attack()
    {
        animator.SetTrigger("attack");
        Collider2D[] hitPlayer = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, playerLayers);

        foreach (Collider2D player in hitPlayer)
        {
            player.GetComponent<PlayerHealth>().TakeDamage(attackDamage);
            print("attack player");
        }
    }
}
