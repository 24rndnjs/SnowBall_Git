using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BathroomClickButton : MonoBehaviour
{
    public void BathRoomBtnOnClick()
    {
        SceneManager.LoadScene("BathRoomScene");
    }
    public void BathRoommirror()
    {////5555
        SceneManager.LoadScene("BathRoomCOPY");
    }
    public void gooutbus()
    {
        LoadingSceneController1.LoadScene("bus");
    }
}
