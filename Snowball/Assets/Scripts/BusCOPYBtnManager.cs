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
                    chatName.text = "���ʹ�";
                    chatName2.text = "���ʹ�";
                    chatTxT.text = "��...��...";
                    chatTxT2.text = "��...��...";
                    Count++;
                }
                else if (Input.GetMouseButtonDown(1))
                {
                    chatName.text = "���ʹ�";
                    chatName2.text = "���ʹ�";
                    chatTxT.text = "��...��...";
                    chatTxT2.text = "��...��...";
                    Count++;
                }
            }

            else if (Count == 1)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    chatName.text = "���̷�";
                    chatName2.text = "���̷�";
                    chatTxT.text = "���� �����մϴ�.!";
                    chatTxT2.text = "���� �����մϴ�.!";
                    Count++;
                }
                else if (Input.GetMouseButtonDown(1))
                {
                    chatName.text = "���̷�";
                    chatName2.text = "���̷�";
                    chatTxT.text = "���� �����մϴ�.!";
                    chatTxT2.text = "���� �����մϴ�.!";
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
