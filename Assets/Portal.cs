using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    private Transform destination;
    public bool isOrange;
    public float distance = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        if (isOrange == false)
        {
            destination = GameObject.FindGameObjectWithTag("orange portal").GetComponent<Transform>();

        }
        else
        {
            destination = GameObject.FindGameObjectWithTag("blue portal").GetComponent<Transform>();
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        print("hit portal");
        if (Vector2.Distance(transform.position, other.transform.position) > distance)
        {
            if (other.gameObject.tag == "Player")
            {
                other.transform.position = new Vector2(destination.position.x, destination.position.y);
            }
        }

    }
}

