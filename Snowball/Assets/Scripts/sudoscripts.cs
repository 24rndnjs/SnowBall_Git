using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sudoscripts : MonoBehaviour
{
    public GameObject Target1;
    public GameObject Target2;
    public GameObject OffSuDoBtn;
    public GameObject OnMirrorTriger;
    public Text Sucses;
    void OnTriggerEnter2D(Collider2D other)
    {
        Target1.SetActive(true);
        Target2.SetActive(true);
    }
    void OnTriggerExit2D(Collider2D other)
    {
        Target1.SetActive(false);
        Target2.SetActive(false);
    }

    public void Take_a_ShowerBtnOnclick()
    {
        Sucses.text = "- ¾Ä±â ¼º°ø! -";
        OffSuDoBtn.SetActive(false);
        OnMirrorTriger.SetActive(true);
    }
}
