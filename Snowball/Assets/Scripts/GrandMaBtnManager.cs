using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GrandMaBtnManager : MonoBehaviour
{
    public GameObject TalkImg;
    public GameObject obj;

    public void GrandTheftAuotoOnClicker()
    {
        obj.GetComponent<move>().enabled = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
