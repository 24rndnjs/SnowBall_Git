using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


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
            transform.localScale = new Vector3(349, 349, 349);
        }
        else if (horizontalInput > 0)
        {
            flipMove = Vector3.right;
            transform.localScale = new Vector3(-349, 349, 349);
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
