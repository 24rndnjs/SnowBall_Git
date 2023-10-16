using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] float setTime = 30.0f;
    [SerializeField] Text countdownText;
    [SerializeField] Text keyPressesText;
    [SerializeField] Text clearText; // �߰�: Ŭ���� �ؽ�Ʈ
    [SerializeField] int maxKeyPresses = 200;
    int currentKeyPresses = 0;
    bool isSpacebarEnabled = true;

    void Start()
    {
        UpdateCountdownText();
        UpdateKeyPressesText();
        clearText.gameObject.SetActive(false); // Ŭ���� �ؽ�Ʈ ��Ȱ��ȭ
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
                isSpacebarEnabled = false; // �����̽��� �Է� ��Ȱ��ȭ
                ShowClearText(); // Ŭ���� �ؽ�Ʈ ǥ��
            }
        }
    }

    void UpdateCountdownText()
    {
        countdownText.text = "���� �ð�: " + Mathf.Round(setTime).ToString();
    }

    void UpdateKeyPressesText()
    {
        keyPressesText.text = "���� ����: " + (maxKeyPresses - currentKeyPresses);
    }

    void ShowClearText()
    {
        clearText.gameObject.SetActive(true); // Ŭ���� �ؽ�Ʈ Ȱ��ȭ
    }
}
