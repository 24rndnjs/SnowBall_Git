using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public int SPEED_move;
    Rigidbody2D rm;
    bool leftpress = false;
    bool rightpress = false;
    float horizontal;
    public SpriteRenderer rend;
    //
    public void Start()
    {
        rm = GetComponent<Rigidbody2D>();
        rend = GetComponent<SpriteRenderer>();
        horizontal= Input.GetAxis("Horizontal");
    }

     void Update()
    {
        if (rm != null)
        {
            float dist = SPEED_move * Time.deltaTime;
            Vector2 pos = transform.position;
            if (Input.GetKeyDown(KeyCode.A))
            {
                leftpress = true;
            }
            if (Input.GetKeyUp(KeyCode.A))
            {
                leftpress = false;
            }
            if (leftpress)
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
            if (rightpress)
            {
                pos.x += dist;
            }
            transform.position = pos;
        }
        if (horizontal > 0)
        {
            rend.flipX = false; // Player의 Sprite를 좌우반전시키는 함수 , true일 때 반전 
        }
    }
}
