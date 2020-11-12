using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndScreenScript : MonoBehaviour
{
    [SerializeField] Text scoreFinalGreen;
    [SerializeField] Text scoreFinalRed;
    public GameObject WinText, LoseText, titleWin, readButton, textReward, titleLose, nextButton, replayButton;
    public int minGreen, minRed;

    // Start is called before the first frame update
    void Start()
    {
        int currentLevel = SceneManager.GetActiveScene().buildIndex;
        scoreFinalGreen.text = "Hijau: " + ScoreText.scoreAmountGreen;
        scoreFinalRed.text = "Merah: " + ScoreText2.scoreAmountRed;

        if (ScoreText.scoreAmountGreen >= minGreen && ScoreText2.scoreAmountRed >= minRed) 
        {
            if (currentLevel >= PlayerPrefs.GetInt("levelUnlocked"))
            {
                PlayerPrefs.SetInt("levelUnlocked", currentLevel+1);
                Debug.Log("level sekarang" + currentLevel);
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