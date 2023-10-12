using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene1 : MonoBehaviour
{
    public void Koonclick()
    {
        SceneManager.LoadScene("Scene1");//s
    }

    public void Koonclick2()
    {
        SceneManager.LoadScene("Scene1COPY");//s
    }
}
