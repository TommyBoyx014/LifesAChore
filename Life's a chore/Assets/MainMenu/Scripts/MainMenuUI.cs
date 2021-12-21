using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuUI : MonoBehaviour
{
    private int score = 0;
    //private int lives = -1;
    [SerializeField] Text scoreText;
    [SerializeField] Text timeText;
    [SerializeField] Button nextLevel;
    private bool timerIsRunning = false;
    private float timeRemaining = 10.0f;

    //[SerializeField] public Text livesText;

    private void Start()
    {
        PlayerPrefs.SetInt("score", score);
        PlayerPrefs.Save();
        //PlayerPrefs.GetInt("lives", lives);
        scoreText.text = "Score: " + score;
        //livesText.text = "Lives: " + lives;
        PlayerPrefs.SetFloat("timeRemaining", timeRemaining);
        nextLevel.enabled = true;
    }
}
