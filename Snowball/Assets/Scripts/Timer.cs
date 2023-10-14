using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] float setTime = 30.0f;
    [SerializeField] Text countdownText;

    void Start()
    {
        countdownText.text = setTime.ToString();
    }

    void Update()
    {
        if (setTime > 0)
        {
            setTime -= Time.deltaTime;
            countdownText.text = Mathf.Round(setTime).ToString();
        }
        else
        {
            setTime = 0f;
            Time.timeScale = 0.0f;
            countdownText.text = Mathf.Round(setTime).ToString();
        }
    }
}
