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
                    chatName.text = "��ü�� ����";
                    chatName2.text = "��ü�� ����";
                    chatTxT.text = "��...�ƴϿ� ���°� �����ϴ�.";
                    chatTxT2.text = "��...�ƴϿ� ���°� �����ϴ�.";
                    Count++;
                }
            }

            else if (Count == 1)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    chatName.text = "���ʹ�";
                    chatName2.text = "���ʹ�";
                    chatTxT.text = "��..�˰ڽ��ϴ�. �����ϼ���....";
                    chatTxT2.text = "��..�˰ڽ��ϴ�. �����ϼ���....";
                    Count++;
                }
            }
            else if (Count == 2)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    chatName.text = "���ʹ�";
                    chatName2.text = "���ʹ�";
                    chatTxT.text = "(��..����..?)";
                    chatTxT2.text = "(��..����..?)";
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
