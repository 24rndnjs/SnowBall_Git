using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GoOutBtnScripts : MonoBehaviour
{
    public GameObject Target1;

    public void ExitBtnClick()
    {
        Target1.SetActive(true);
    }
    public void BalSoExitBtnOnClik()
    {
        SceneManager.LoadScene("BaljunsoCopy");
    }
}
