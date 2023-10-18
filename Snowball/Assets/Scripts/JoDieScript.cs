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
                    chatName.text = "전초밤";
                    chatName2.text = "전초밤";
                    chatTxT.text = "어!!...괜찮으세요?!!!";
                    chatTxT2.text = "어!!...괜찮으세요?!!!";
                    Count++;
                }
            }
            else if (Count == 1)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    chatName.text = "조미류";
                    chatName2.text = "조미류";
                    chatTxT.text = "살...살려줘어........";
                    chatTxT2.text = "살...살려줘어........";
                    Count++;
                }
            }
            else if(Count==2)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    chatName.text = "전초밤";
                    chatName2.text = "전초밤";
                    chatTxT.text = "정신차리세요!!";
                    chatTxT2.text = "정신차리세요!!";
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
