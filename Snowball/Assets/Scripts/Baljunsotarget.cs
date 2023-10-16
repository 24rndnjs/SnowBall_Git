using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baljunsotarget : MonoBehaviour
{
    // Start is called before the first frame update
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
    private void Update()
    {
        this.transform.position = Vector3.MoveTowards(this.transform.position, _targetObj.transform.position, _Speed * Time.deltaTime);
    }
}
