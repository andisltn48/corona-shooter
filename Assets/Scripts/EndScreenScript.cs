using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndScreenScript : MonoBehaviour
{
    [SerializeField] Text scoreFinalText;
    public GameObject WinText, LoseText, titleWin, readButton, textReward, titleLose, nextButton, replayButton;
    

    // Start is called before the first frame update
    void Start()
    {
        int currentLevel = SceneManager.GetActiveScene().buildIndex;
        scoreFinalText.text = "Score : " + ScoreText.scoreAmount;

        if (ScoreText.scoreAmount >= 1)
        {
            if (currentLevel >= PlayerPrefs.GetInt("levelUnlocked"))
            {
                PlayerPrefs.SetInt("levelUnlocked", currentLevel + 1);
            }
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