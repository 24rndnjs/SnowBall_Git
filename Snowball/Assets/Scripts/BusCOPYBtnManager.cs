using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BusCOPYBtnManager : MonoBehaviour
{
    public GameObject Jotrigeroff;
    public GameObject TalkImg;
    public GameObject BusSpriteoff;
    public GameObject OnBusTriger;
    public GameObject obj;
    public Text chatName;
    public Text chatName2;
    public Text chatTxT;
    public Text chatTxT2;
    public GameObject BusSpriteon;
    bool Cheak = false;
    int Count = 0;

    public void JoBtnOnclick()
    {
        Jotrigeroff.SetActive(false);
        TalkImg.SetActive(true);
        BusSpriteoff.SetActive(false);
        OnBusTriger.SetActive(true);
        obj.GetComponent<Buscharactermove>().enabled = false;
        SetBool();
    }
    void SetBool()
    {
        Cheak = true;
    }

    void Update()
    {
        if (Cheak == true)
        {
            if(Count == 0)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    chatName.text = "전초밤";
                    chatName2.text = "전초밤";
                    chatTxT.text = "아...네...";
                    chatTxT2.text = "아...네...";
                    Count++;
                }
                else if (Input.GetMouseButtonDown(1))
                {
                    chatName.text = "전초밤";
                    chatName2.text = "전초밤";
                    chatTxT.text = "아...네...";
                    chatTxT2.text = "아...네...";
                    Count++;
                }
            }

            else if (Count == 1)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    chatName.text = "조미류";
                    chatName2.text = "조미류";
                    chatTxT.text = "정말 감사합니다.!";
                    chatTxT2.text = "정말 감사합니다.!";
                    Count++;
                }
                else if (Input.GetMouseButtonDown(1))
                {
                    chatName.text = "조미류";
                    chatName2.text = "조미류";
                    chatTxT.text = "정말 감사합니다.!";
                    chatTxT2.text = "정말 감사합니다.!";
                    Count++;
                }
            }
            else if (Count == 2)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    Count++;
                }
                else if (Input.GetMouseButtonDown(1))
                {
                    Count++;
                }
            }

            else if (Count == 3)
            {
                BusSpriteon.SetActive(true);
                TalkImg.SetActive(false);
                obj.GetComponent<Buscharactermove>().enabled = true;
                Cheak = false;
            }
        }
    }
}
