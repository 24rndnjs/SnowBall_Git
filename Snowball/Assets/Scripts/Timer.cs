using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] float setTime = 30.0f;
    [SerializeField] Text countdownText;
    [SerializeField] Text keyPressesText;
    [SerializeField] int maxKeyPresses = 200;
    int currentKeyPresses = 0;

    void Start()
    {
        UpdateCountdownText();
        UpdateKeyPressesText();
    }

    void Update()
    {
        if (setTime > 0 && currentKeyPresses < maxKeyPresses)
        {
            setTime -= Time.deltaTime;
            UpdateCountdownText();
        }
        else
        {
            setTime = 0f;
            Time.timeScale = 0.0f;
            UpdateCountdownText();
        }

        if (Input.GetKeyDown(KeyCode.Space) && currentKeyPresses < maxKeyPresses)
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
}
