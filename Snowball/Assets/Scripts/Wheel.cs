using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheel: MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        // Animator ������Ʈ ��������
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("isWheeling", true);
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            animator.SetBool("isWheeling", false);
        }
    }
}

