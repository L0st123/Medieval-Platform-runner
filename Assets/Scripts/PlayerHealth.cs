using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health;
    public int maxHealth = 10;

    public SpriteRenderer playerSr;
    public PlayerScript playerMovement;
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }
    public void TakeDamage(int amount)
    {
        health -= amount; 
        if( health <= 0)
        {
            playerSr.enabled = false;
            playerMovement.enabled = false;
            
        }
    }

}
