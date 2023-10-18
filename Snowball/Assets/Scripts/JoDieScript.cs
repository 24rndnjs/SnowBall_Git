using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class JoDieScript : MonoBehaviour
{
    public GameObject Jotrigeroff;
    public GameObject TalkImg;
    public GameObject BusSprite;
    public GameObject obj;
    public Text chatName;
    public Text chatName2;
    public Text chatTxT;
    public Text chatTxT2;
    bool Cheak = false;
    int Count = 0;

    public void JoBtnOnclick()
    {
        Jotrigeroff.SetActive(false);
        TalkImg.SetActive(true);
        BusSprite.SetActive(false);
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
            if (Count == 0)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    chatName.text = "���ʹ�";
                    chatName2.text = "���ʹ�";
                    chatTxT.text = "��!!...����������?!!!";
                    chatTxT2.text = "��!!...����������?!!!";
                    Count++;
                }
            }
            else if (Count == 1)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    chatName.text = "���̷�";
                    chatName2.text = "���̷�";
                    chatTxT.text = "��...������........";
                    chatTxT2.text = "��...������........";
                    Count++;
                }
            }
            else if(Count==2)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    chatName.text = "���ʹ�";
                    chatName2.text = "���ʹ�";
                    chatTxT.text = "������������!!";
                    chatTxT2.text = "������������!!";
                    Count++;
                }
            }
            else if (Count == 3)
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

            else if (Count == 4)
            {
                BusSprite.SetActive(true);
                TalkImg.SetActive(false);
                obj.GetComponent<Buscharactermove>().enabled = true;
                Cheak = false;
                SceneManager.LoadScene("ambulance");
            }
        }
    }
}
