using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameplayManager : MonoBehaviour
{
    public int Score;
    public float playtime = 60f;
    public TMP_Text scoreText;
    public TMP_Text timeText;

    private void Update()
    {
        playtime -= Time.deltaTime;
        UpdateScoreUI();
        UpdateTimeUI();
    }

    public void addScore(int score)
    {
        Score += score;
    }
    void UpdateScoreUI()
    {
        scoreText.text = "Score : " + Score.ToString();
    }
    void UpdateTimeUI()
    {
        timeText.text = "Time : " + playtime.ToString();
    }
}
