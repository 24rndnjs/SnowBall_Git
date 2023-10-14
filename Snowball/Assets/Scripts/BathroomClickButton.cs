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
    {
        SceneManager.LoadScene("BathRoomCOPY");
    }
    public void gooutbus()
    {
        SceneManager.LoadScene("bus");
    }
}
