using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene1TVScripts : MonoBehaviour
{
    public GameObject Target1;
    public GameObject Target2;
    public GameObject Target3;
    public GameObject Target4;
    public GameObject Target5;
    public GameObject Target6;
    public GameObject Target7;

    public void TVBtnOnClick()
    {
        Target1.SetActive(false);
        Target2.SetActive(false);
        Target3.SetActive(false);
        Target4.SetActive(true);
        Target5.SetActive(true);
    }
    public void TVoffBtnOnClick()
    {
        Target6.SetActive(false);
        Target7.SetActive(false);
    }
}
