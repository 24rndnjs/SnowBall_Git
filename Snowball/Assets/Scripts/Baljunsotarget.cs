using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Baljunsotarget : MonoBehaviour
{
    // Start is called before the first frame update
    public float _Speed; //¼Óµµ
    private Vector3 _direct = Vector3.zero;
    private GameObject _targetObj;
    private float fDestroyTime = 0.5f;
    private float fTickTime;
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

        if (transform.position == _targetObj.transform.position)
        {
            fTickTime += Time.deltaTime;

            if (fTickTime >= fDestroyTime)
            {
                SceneManager.LoadScene("wheel");
            }
        }
        this.transform.position = Vector3.MoveTowards(this.transform.position, _targetObj.transform.position, _Speed * Time.deltaTime);
    }
}
