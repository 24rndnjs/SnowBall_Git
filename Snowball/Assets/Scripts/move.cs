using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float SPEED_move; // SPEED_move를 float로 변경
    Rigidbody2D rm;
    bool leftpress = false;
    bool rightpress = false;
    SpriteRenderer spriteRenderer;
    Animator anim;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        rm = GetComponent<Rigidbody2D>(); // rm 초기화
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal"); // Input.GetAxis("Horizontal")을 여기서 읽도록 변경

        // 방향 전환
        if (horizontal < 0)
            spriteRenderer.flipX = false; // 왼쪽으로 움직일 때는 오른쪽을 보도록 설정
        else if (horizontal > 0)
            spriteRenderer.flipX = true; // 오른쪽으로 움직일 때는 왼쪽을 보도록 설정

        // 애니메이션
        anim.SetBool("isWalking", Mathf.Abs(horizontal) > 0);

        // 이동 로직
        float dist = SPEED_move * horizontal * Time.deltaTime;
        Vector2 pos = transform.position;

        if (horizontal != 0)
        {
            pos.x += dist;
            transform.position = pos;
        }
    }
}
