using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{

    public float increase = 100f;
    float speed = 3f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
     void OnTriggerEnter2D(Collider2D collision)
    {
        print("speed increased");
        speed = increase;
        Destroy(gameObject);    
    }
}
  