using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float SPEED_move; // SPEED_move�� float�� ����
    Rigidbody2D rm;
    bool leftpress = false;
    bool rightpress = false;
    SpriteRenderer spriteRenderer;
    Animator anim;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        rm = GetComponent<Rigidbody2D>(); // rm �ʱ�ȭ
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal"); // Input.GetAxis("Horizontal")�� ���⼭ �е��� ����

        // ���� ��ȯ
        if (horizontal < 0)
            spriteRenderer.flipX = false; // �������� ������ ���� �������� ������ ����
        else if (horizontal > 0)
            spriteRenderer.flipX = true; // ���������� ������ ���� ������ ������ ����

        // �ִϸ��̼�
        anim.SetBool("isWalking", Mathf.Abs(horizontal) > 0);

        // �̵� ����
        float dist = SPEED_move * horizontal * Time.deltaTime;
        Vector2 pos = transform.position;

        if (horizontal != 0)
        {
            pos.x += dist;
            transform.position = pos;
        }
    }
}
