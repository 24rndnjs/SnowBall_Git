using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buscharactermove : MonoBehaviour
{
    [SerializeField][Range(1f, 10f)] float moveSpeed = 3f;
    Animator animator;

    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        Vector3 flipMove = Vector3.zero;

        if (horizontalInput < 0)
        {
            flipMove = Vector3.left;
            transform.localScale = new Vector3(0.190975f, 0.55182f, 0.6161985f);
        }
        else if (horizontalInput > 0)
        {
            flipMove = Vector3.right;
            transform.localScale = new Vector3(-0.190975f, 0.55182f, 0.6161985f);
        }

        transform.position += flipMove * moveSpeed * Time.deltaTime;

        // �ȱ� �ִϸ��̼� ����
        if (Mathf.Abs(horizontalInput) > 0)
        {
            animator.SetBool("isWalking", true);
        }
        else
        {
            animator.SetBool("isWalking", false);
        }
    }
}