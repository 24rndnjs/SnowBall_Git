using UnityEngine;

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
        // �����̽��ٸ� ������ �� isWheeling �Ķ���͸� true�� �����Ͽ� �ִϸ��̼� ���
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // "isWheeling" �Ķ���͸� true�� �����Ͽ� Wheeling �ִϸ��̼��� ���
            animator.SetBool("isWheeling", true);
        }
        // �����̽��ٸ� ������ �� isWheeling �Ķ���͸� false�� �����Ͽ� �ִϸ��̼� ����
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            // "isWheeling" �Ķ���͸� false�� �����Ͽ� Wheeling �ִϸ��̼��� ����
            animator.SetBool("isWheeling", false);
        }
    }
}

