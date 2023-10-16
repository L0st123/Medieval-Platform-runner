using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int maxHealth = 3;
    public int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TakeDamageEnemy(int amount)
    {
        currentHealth -= amount;
        if(currentHealth <= 0)
        {
            Death(); 
        }
    }
    void Death()
    {
        this.GetComponent<Collider2D>().enabled = false;
        this.GetComponent<EnemyScript>().enabled = false;
        this.GetComponent<EnemyDamage>().enabled = false;
    }
   
}
