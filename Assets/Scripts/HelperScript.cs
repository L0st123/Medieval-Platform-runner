using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelperScript : MonoBehaviour
{
    LayerMask groundLayerMask;




    void Start()
    {
        groundLayerMask = LayerMask.GetMask("Ground");
    }


    public void FlipSprite( bool flipX)
    {
        if (flipX)
        {
            gameObject.transform.localScale = new Vector3(-2, 2, 2);
        }
        else
        {
            gameObject.transform.localScale = new Vector3(2, 2, 2);
        }
        
    }
    public bool DoRayCollisionCheck( Vector2 direction, float xOffset, float yOffset )
    {
        bool hitFlag = false;
        float rayLength = 0.5f; // length of raycast


        //cast a ray downward 
        RaycastHit2D hit;

        Vector3 offset = new Vector3(xOffset, yOffset, 0);    

        hit = Physics2D.Raycast(transform.position + offset, direction, rayLength, groundLayerMask);

        Color hitColor = Color.white;

        if (hit.collider != null)
        {
            print("Player has collided with Ground layer");
            hitColor = Color.green;
            hitFlag = true;
        }
        // draw a debug ray to show ray position
        // You need to enable gizmos in the editor to see these
        Debug.DrawRay(transform.position + offset, direction * rayLength, hitColor);

        return hitFlag;

    }



}


