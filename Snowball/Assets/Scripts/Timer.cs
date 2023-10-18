using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] float setTime = 20.0f;
    [SerializeField] Text countdownText;
    [SerializeField] Text keyPressesText;
    [SerializeField] Text clearText;
    [SerializeField] int maxKeyPresses = 200;
    [SerializeField] Text failText;
    int currentKeyPresses = 0;
    bool isSpacebarEnabled = true;
    bool hasFailed = false;

    void Start()
    {
        UpdateCountdownText();
        UpdateKeyPressesText();
        clearText.gameObject.SetActive(false);
        failText.gameObject.SetActive(false);
    }

    void Update()
    {
        if (setTime > 0 && currentKeyPresses < maxKeyPresses && !hasFailed)
        {
            setTime -= Time.deltaTime;
            UpdateCountdownText();
        }

        if (setTime <= 0 || currentKeyPresses >= maxKeyPresses)
        {
            if (!hasFailed)
            {
                if (currentKeyPresses >= maxKeyPresses)
                {
                    clearText.gameObject.SetActive(true);
                    SceneManager.LoadScene("tongro");
                }
                else
                {
                    failText.gameObject.SetActive(true);
                }
                isSpacebarEnabled = false;
                hasFailed = true;
                StartCoroutine(LoadFailedScene());
            }
        }

        if (isSpacebarEnabled && Input.GetKeyDown(KeyCode.Space) && currentKeyPresses < maxKeyPresses && !hasFailed)
        {
            currentKeyPresses++;
            UpdateKeyPressesText();
        }
    }

    void UpdateCountdownText()
    {
        countdownText.text = "남은 시간: " + Mathf.Round(setTime).ToString();
    }

    void UpdateKeyPressesText()
    {
        keyPressesText.text = "남은 갯수: " + (maxKeyPresses - currentKeyPresses);
    }

    IEnumerator LoadFailedScene()
    {
        yield return new WaitForSeconds(2f); // Wait for 2 seconds before loading the Failed scene
        SceneManager.LoadScene("Failed");
    }
}
