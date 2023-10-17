using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class copymove : MonoBehaviour
{//
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
            transform.localScale = new Vector3(0.2654253f, 0.6791947f, 6.83286f);
        }
        else if (horizontalInput > 0)
        {
            flipMove = Vector3.right;
            transform.localScale = new Vector3(-0.2654253f, 0.6791947f, 6.83286f);
        }

        transform.position += flipMove * moveSpeed * Time.deltaTime;

        // 걷기 애니메이션 제어
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
