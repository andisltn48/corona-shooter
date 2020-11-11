using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScreenScript : MonoBehaviour
{
    [SerializeField] Text scoreFinalText;
    public GameObject WinText, LoseText, titleWin, readButton, textReward, titleLose, nextButton, replayButton;
    

    // Start is called before the first frame update
    void Start()
    {
        scoreFinalText.text = "Score : " + ScoreText.scoreAmount;
        if (ScoreText.scoreAmount >= 1)
        {
            WinText.SetActive(true);
        }
        else
        {
            LoseText.SetActive(true);
            titleLose.SetActive(true);
            replayButton.SetActive(true);
            readButton.SetActive(false);
            nextButton.SetActive(false);
            titleWin.SetActive(false);

        }
    }
    public void bacaLembaran()
    {
        textReward.SetActive(true);
        readButton.SetActive(false);
        titleWin.SetActive(false);
    }
}