using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GrandMaBtnManager : MonoBehaviour
{
    public GameObject TalkImg;
    public GameObject obj;
    public GameObject grandtheftaoutotriger;
    public Text chatName;
    public Text chatName2;
    public Text chatTxT;
    public Text chatTxT2;
    bool Cheak = false;
    int Count = 0;

    public void GrandTheftAuotoOnClicker()
    {
        TalkImg.SetActive(true);
        obj.GetComponent<move>().enabled = false;
        SetBool();
    }

    void SetBool()
    {
        Cheak = true;
    }

    // Update is called once per frame
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
                    chatTxT.text = "할머니 잘 다녀올게요!";
                    chatTxT2.text = "할머니 잘 다녀올게요!";
                    Count++;
                }
                else if (Input.GetMouseButtonDown(1))
                {
                    chatName.text = "전초밤";
                    chatName2.text = "전초밤";
                    chatTxT.text = "할머니 잘 다녀올게요!";
                    chatTxT2.text = "할머니 잘 다녀올게요!";
                    Count++;
                }
            }

            else if (Count == 1)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    chatName.text = "할머니";
                    chatName2.text = "할머니";
                    chatTxT.text = "아이고 온기 여자친구! 잘 다녀 와요!";
                    chatTxT2.text = "아이고 온기 여자친구! 잘 다녀 와요!";
                    Count++;
                }
                else if (Input.GetMouseButtonDown(1))
                {
                    chatName.text = "할머니";
                    chatName2.text = "할머니";
                    chatTxT.text = "아이고 온기 여자친구! 잘 다녀 와요!";
                    chatTxT2.text = "아이고 온기 여자친구! 잘 다녀 와요!";
                    Count++;
                }
            }
            else if (Count == 2)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    chatName.text = "전초밤";
                    chatName2.text = "전초밤";
                    chatTxT.text = "할머니 여자친구 아니라니까요~";
                    chatTxT2.text = "할머니 여자친구 아니라니까요~";
                    Count++;
                }
                else if (Input.GetMouseButtonDown(1))
                {
                    chatName.text = "전초밤";
                    chatName2.text = "전초밤";
                    chatTxT.text = "할머니 여자친구 아니라니까요~";
                    chatTxT2.text = "할머니 여자친구 아니라니까요~";
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

            if (Count == 4)
            {
                TalkImg.SetActive(false);
                grandtheftaoutotriger.SetActive(false);
                obj.GetComponent<move>().enabled = true;
                Cheak = false;
            }
        }
    }
}
