using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyhealth : MonoBehaviour
{
    public Animator animator;
    public int maxhealth = 3;
    public int currenthealth;
    // Start is called before the first frame update
    void Start()
    {
        currenthealth = maxhealth; 
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void TakeDamageEnemy(int amount)
    {

    }
}
