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
                    chatName.text = "���ʹ�";
                    chatName2.text = "���ʹ�";
                    chatTxT.text = "�ҸӴ� �� �ٳ�ðԿ�!";
                    chatTxT2.text = "�ҸӴ� �� �ٳ�ðԿ�!";
                    Count++;
                }
                else if (Input.GetMouseButtonDown(1))
                {
                    chatName.text = "���ʹ�";
                    chatName2.text = "���ʹ�";
                    chatTxT.text = "�ҸӴ� �� �ٳ�ðԿ�!";
                    chatTxT2.text = "�ҸӴ� �� �ٳ�ðԿ�!";
                    Count++;
                }
            }

            else if (Count == 1)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    chatName.text = "�ҸӴ�";
                    chatName2.text = "�ҸӴ�";
                    chatTxT.text = "���̰� �±� ����ģ��! �� �ٳ� �Ϳ�!";
                    chatTxT2.text = "���̰� �±� ����ģ��! �� �ٳ� �Ϳ�!";
                    Count++;
                }
                else if (Input.GetMouseButtonDown(1))
                {
                    chatName.text = "�ҸӴ�";
                    chatName2.text = "�ҸӴ�";
                    chatTxT.text = "���̰� �±� ����ģ��! �� �ٳ� �Ϳ�!";
                    chatTxT2.text = "���̰� �±� ����ģ��! �� �ٳ� �Ϳ�!";
                    Count++;
                }
            }
            else if (Count == 2)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    chatName.text = "���ʹ�";
                    chatName2.text = "���ʹ�";
                    chatTxT.text = "�ҸӴ� ����ģ�� �ƴ϶�ϱ��~";
                    chatTxT2.text = "�ҸӴ� ����ģ�� �ƴ϶�ϱ��~";
                    Count++;
                }
                else if (Input.GetMouseButtonDown(1))
                {
                    chatName.text = "���ʹ�";
                    chatName2.text = "���ʹ�";
                    chatTxT.text = "�ҸӴ� ����ģ�� �ƴ϶�ϱ��~";
                    chatTxT2.text = "�ҸӴ� ����ģ�� �ƴ϶�ϱ��~";
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
