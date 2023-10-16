using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene1TVScripts : MonoBehaviour
{
    public GameObject Target1;
    public GameObject Target2;

    public void TVBtnOnClick()
    {
        Target1.SetActive(false);
        Target2.SetActive(true);
    }
}
