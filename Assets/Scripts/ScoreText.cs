using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{

    public static int scoreAmountGreen, scoreAmountRed;
    private Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<Text>();
        scoreAmountGreen = 0;
        scoreAmountRed = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = scoreAmountGreen.ToString();
        scoreText.text = scoreAmountGreen.ToString();
    }
}
