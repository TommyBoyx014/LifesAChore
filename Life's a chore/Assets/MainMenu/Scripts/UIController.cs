using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    private int score = -1;
    //private int lives = -1;
    [SerializeField] Text scoreText;
    [SerializeField] Text timeText;
    [SerializeField] Text tirePressure;
    [SerializeField] Button nextLevel;
    private bool timerIsRunning = true;
    private float timeRemaining = 10.0f;

    //[SerializeField] public Text livesText;

    private void Start()
    {
        PlayerPrefs.GetInt("score", score);
        //PlayerPrefs.GetInt("lives", lives);
        scoreText.text = "Score: " + score;
        //livesText.text = "Lives: " + lives;
        PlayerPrefs.SetFloat("timeRemaining", timeRemaining);
        nextLevel.enabled = false;
    }

    private void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            else
            {
                Debug.Log("Time has run out!");
                timeRemaining = 0;
                PlayerPrefs.SetFloat("timeRemaining", timeRemaining);
                timerIsRunning = false;
            }
        }
        timeText.text = "Time: " + timeRemaining;

        if(PlayerPrefs.GetInt("score") != score)
        {
            nextLevel.enabled = true;
        }
    }
}
