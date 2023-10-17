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
    //    chatName.text="전초밤";
    //    chatName2.text="점초밤";
    //    chatTxT.text="네 그럴게요.";
    //    chatTxT2.text="네 그럴게요.";
    //}
    //void Chat2()
    //{
    //    chatName.text = "조미류";
    //    chatName2.text = "조미류";
    //    chatTxT.text = "정말 감사합니다.!";
    //    chatTxT2.text ="정말 감사합니다.!";
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
