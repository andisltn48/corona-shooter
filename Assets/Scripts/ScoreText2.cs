using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText2 : MonoBehaviour
{
    public static int scoreAmountRed;
    private Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<Text>();
        scoreAmountRed = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = scoreAmountRed.ToString();
    }
}
