using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuDoAniScript : MonoBehaviour
{
    public Animator animator; // Animator �Ӽ� ���� ����

    private void Start()
    {
        animator = GetComponent<Animator>(); // animator ������ Player�� Animator �Ӽ����� �ʱ�ȭ
    }

    public void SuDoAni()
    {
        animator.SetBool("SuDo", true);
    }

}
