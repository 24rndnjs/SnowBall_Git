using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartClick : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            LoadingSceneController.LoadScene("Scene1");
        }
        else if (Input.GetMouseButtonDown(1))
        {
            LoadingSceneController.LoadScene("Scene1");
        }
    }
}
