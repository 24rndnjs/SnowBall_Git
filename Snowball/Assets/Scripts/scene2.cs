using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene2 : MonoBehaviour
{
    public void Minjionclick()
    {

        SceneManager.LoadScene("Scene2");
    }

    public void Minjionclick1111()
    {

        SceneManager.LoadScene("Scene2 Copy");
    }
    public void failed()
    {
        SceneManager.LoadScene("wheel");
    }
    public void WHEEL()
    {

        SceneManager.LoadScene("Inbaljunso");
    }
    public void Busloading()
    {

        SceneManager.LoadScene("Baljunso");
    }
    public void Rerode()
    {
        SceneManager.LoadScene("wheelCopy");
    }
    public void waybackhome()
    {
        SceneManager.LoadScene("BaljunsoCopy");
    }
    public void last()
    {
        SceneManager.LoadScene("lastscene");
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("Credit");
        }
        if (Input.GetMouseButtonDown(1))
        {
            SceneManager.LoadScene("Credit");
        }
    }
    //public void credit()
    //{
    //    SceneManager.LoadScene("Credit");
    //}
}
