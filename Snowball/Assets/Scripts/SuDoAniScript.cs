using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuDoAniScript : MonoBehaviour
{
    public Animator animator; // Animator 속성 변수 생성

    private void Start()
    {
        animator = GetComponent<Animator>(); // animator 변수를 Player의 Animator 속성으로 초기화
    }

    public void SuDoAni()
    {
        animator.SetBool("SuDo", true);
    }

}
