using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    float currentTime = 0f;
    public int timeLimit;
    [SerializeField] Text countdownText;
    public GameObject GameOverScreen;

    // Start is called before the first frame update

    void Start()
    {
        currentTime = timeLimit;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");
        if (currentTime <= 0) {
            currentTime = 0;
            Debug.Log("abis");
            GameOverScreen.SetActive(true);
        }
    }
}
