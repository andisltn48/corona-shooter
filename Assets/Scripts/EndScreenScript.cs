using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScreenScript : MonoBehaviour
{
    [SerializeField] Text scoreFinalText;
    public GameObject WinText;
    public GameObject LoseText;

    // Start is called before the first frame update
    void Start()
    {
        scoreFinalText.text = "Score : " + ScoreText.scoreAmount;
        if (ScoreText.scoreAmount >= 20)
        {
            WinText.SetActive(true);
        }
        else
        {
            LoseText.SetActive(true);
        }
    }
}