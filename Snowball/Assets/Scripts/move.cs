using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    [SerializeField] [Range(1f, 10f)] float moveSpeed = 3f;
    Animator animator;
    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        Vector3 flipMove = Vector3.zero;
        if(Input.GetAxisRaw("Horizontal") < 0)
        {
            flipMove = Vector3.left;
            transform.localScale=new Vector3(480, 486, 54);
        }
        else if(Input.GetAxisRaw("Horizontal") > 0)
        {
            flipMove = Vector3.right;
            transform.localScale = new Vector3(-480, 486, 54);
        }
        transform.position += flipMove * moveSpeed * Time.deltaTime;
        
    }
}
