using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PostOfficeScript : MonoBehaviour
{
    public GameObject TalkImg;
    public GameObject obj;
    public GameObject posttriger;
    public GameObject triger1;
    public Text chatName;
    public Text chatName2;
    public Text chatTxT;
    public Text chatTxT2;
    bool Cheak = false;
    int Count = 0;

    public void PostBtnOnClicker()
    {
        posttriger.SetActive(false);
        triger1.SetActive(true);
        TalkImg.SetActive(true);
        obj.GetComponent<Buscharactermove>().enabled = false;
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
                    chatName.text = "우체국 직원";
                    chatName2.text = "우체국 직원";
                    chatTxT.text = "어...아니요 없는것 같습니다.";
                    chatTxT2.text = "어...아니요 없는것 같습니다.";
                    Count++;
                }
            }

            else if (Count == 1)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    chatName.text = "전초밤";
                    chatName2.text = "전초밤";
                    chatTxT.text = "아..알겠습니다. 수고하세요....";
                    chatTxT2.text = "아..알겠습니다. 수고하세요....";
                    Count++;
                }
            }
            else if (Count == 2)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    chatName.text = "전초밤";
                    chatName2.text = "전초밤";
                    chatTxT.text = "(흠..뭐지..?)";
                    chatTxT2.text = "(흠..뭐지..?)";
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
                obj.GetComponent<Buscharactermove>().enabled = true;
                Cheak = false;
            }
        }
    }
}
