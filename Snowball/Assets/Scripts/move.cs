using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public int SPEED_move;
    Rigidbody2D rm;
    bool leftpress = false;
    bool rightpress = false;
    //
    public void Start()
    {
        rm = GetComponent<Rigidbody2D>();
    }

     void Update()
    {
        if(rm!= null)
        {
            float dist=SPEED_move*Time.deltaTime;
            Vector2 pos = transform.position;
            if(Input.GetKeyDown(KeyCode.A))
            {
                leftpress = true;
            }
            if (Input.GetKeyUp(KeyCode.A))
            {
                leftpress = false;
            }
            if(leftpress)
            {
                pos.x -= dist;
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                rightpress = true;  
            }
            if (Input.GetKeyUp(KeyCode.D))
            {
                rightpress = false;
            }
            if(rightpress)
            {
                pos.x += dist;
            }
            transform.position = pos;
        }
        
    }
}
