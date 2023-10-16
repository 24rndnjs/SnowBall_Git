using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] float setTime = 30.0f;
    [SerializeField] Text countdownText;
    [SerializeField] Text keyPressesText;
    [SerializeField] Text clearText; // 추가: 클리어 텍스트
    [SerializeField] int maxKeyPresses = 200;
    int currentKeyPresses = 0;
    bool isSpacebarEnabled = true;

    void Start()
    {
        UpdateCountdownText();
        UpdateKeyPressesText();
        clearText.gameObject.SetActive(false); // 클리어 텍스트 비활성화
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

        if (isSpacebarEnabled && Input.GetKeyDown(KeyCode.Space) && currentKeyPresses < maxKeyPresses)
        {
            currentKeyPresses++;
            UpdateKeyPressesText();

            if (currentKeyPresses >= maxKeyPresses)
            {
                isSpacebarEnabled = false; // 스페이스바 입력 비활성화
                ShowClearText(); // 클리어 텍스트 표시
            }
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

    void ShowClearText()
    {
        clearText.gameObject.SetActive(true); // 클리어 텍스트 활성화
    }
}
