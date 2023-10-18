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
        // 스페이스바를 눌렀을 때 isWheeling 파라미터를 true로 설정하여 애니메이션 재생
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // "isWheeling" 파라미터를 true로 설정하여 Wheeling 애니메이션을 재생
            animator.SetBool("isWheeling", true);
        }
        // 스페이스바를 떼었을 때 isWheeling 파라미터를 false로 설정하여 애니메이션 중지
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            // "isWheeling" 파라미터를 false로 설정하여 Wheeling 애니메이션을 중지
            animator.SetBool("isWheeling", false);
        }
    }
}

