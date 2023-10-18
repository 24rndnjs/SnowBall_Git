using UnityEngine;

using UnityEngine;

public class Wheel: MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        // Animator 컴포넌트 가져오기
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

