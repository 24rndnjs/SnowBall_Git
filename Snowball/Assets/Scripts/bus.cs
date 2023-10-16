using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bus : MonoBehaviour
{
    public float _Speed; //¼Óµµ
    private Vector3 _direct = Vector3.zero;
    private GameObject _targetObj;

    // Start is called before the first frame update
    void Start()
    {
        _direct = new Vector3(-1.0f, 1.0f, 0.0f).normalized;
        _targetObj = GameObject.Find("Target");
    }

    private void Move1()
    {
        this.transform.position += new Vector3(0.0f, 0.01f, 0.0f);
    }


    void Update()
    {
        if(transform.position == _targetObj.transform.position)
        {
            SceneManager.LoadScene("busCOPY");
        }
        this.transform.position = Vector3.MoveTowards(this.transform.position, _targetObj.transform.position, _Speed * Time.deltaTime);
    }
}
