using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusCOPYBtnManager : MonoBehaviour
{
    public GameObject Jotrigeroff;
    public GameObject TalkImg;
    public GameObject BusSpriteoff;
    public GameObject obj;

    public void JoBtnOnclick()
    {
        Jotrigeroff.SetActive(false);
        TalkImg.SetActive(true);
        BusSpriteoff.SetActive(false);
        obj.GetComponent<Buscharactermove>().enabled = false;
    }
}
