using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChatWindowScripts : MonoBehaviour
{
    public Text chatName;
    public Text chatName2;
    public Text chatTxT;
    public Text chatTxT2;
    public GameObject ChatWindow;
    public GameObject obj;
    int Count=0;

    public void Awake()
    {
        while(Count<2)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Count++;
            }
            if (Input.GetMouseButtonDown(1))
            {
                Count++;
            }
            else if (Count == 2)
            {
                obj.GetComponent<Buscharactermove>().enabled = true;
            }
        }
    }
    //void Chat1()
    //{
    //    chatName.text="���ʹ�";
    //    chatName2.text="���ʹ�";
    //    chatTxT.text="�� �׷��Կ�.";
    //    chatTxT2.text="�� �׷��Կ�.";
    //}
    //void Chat2()
    //{
    //    chatName.text = "���̷�";
    //    chatName2.text = "���̷�";
    //    chatTxT.text = "���� �����մϴ�.!";
    //    chatTxT2.text ="���� �����մϴ�.!";
    //    if (Input.GetMouseButtonDown(0))
    //    {
            
    //    }
    //    else if (Input.GetMouseButtonDown(1))
    //    {
    //        obj.GetComponent<Buscharactermove>().enabled = true;
    //    }
    //}
    //void Chat3()
    //{

    //}
}
