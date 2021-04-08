using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class HighScoreTable : MonoBehaviour
{
    public GameObject textToDisable;
    public Text HighScoreText;
    public Text ScoreText;
    int High_Score;
    float score;

    void Start()
    {
        PlayerPrefs.DeleteAll();
        score = 0;
    }

    void Update()
    {
        score += Time.deltaTime * 20;
        High_Score = (int)score;
        ScoreText.text = High_Score.ToString();

        if(PlayerPrefs.GetInt("score") <= High_Score)
            PlayerPrefs.SetInt("score", High_Score);
    }

    public void SetHighScore()
    {
        HighScoreText.text = PlayerPrefs.GetInt("score").ToString();
        textToDisable.SetActive(false);
    }
}
