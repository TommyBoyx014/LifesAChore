using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GetInsideUI : MonoBehaviour
{
    private int score = -1;
    //private int lives = -1;
    [SerializeField] Text scoreText;
    [SerializeField] Text timeText;
    [SerializeField] Button nextLevel;
    private bool timerIsRunning = true;
    private float timeRemaining = 10.0f;
    private bool done = false;

    //[SerializeField] public Text livesText;

    private void Start()
    {
        Debug.Log("score1: " + score);
        PlayerPrefs.GetInt("score", score); //Get the score from previous game
        Debug.Log("score2: " + score);
        //PlayerPrefs.GetInt("lives", lives);
        scoreText.text = "Score: " + score; //Display score
        //livesText.text = "Lives: " + lives;
        PlayerPrefs.SetFloat("timeRemaining", timeRemaining); //reset the time remaining
        nextLevel.gameObject.SetActive(false); //turn off the next level button
    }

    private void Update()
    {
        //Count down timer
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            else //If time runs out game over
            {
                Debug.Log("Time has run out!");
                timeRemaining = 0;
                PlayerPrefs.SetFloat("timeRemaining", timeRemaining);
                timerIsRunning = false;
                gameOver();
            }
        }
        timeText.text = "Time: " + timeRemaining; //Display time

        //if score changed, enable next button and increase player score
        if (PlayerPrefs.GetInt("score") != score)
        {
            Debug.Log("" + PlayerPrefs.GetInt("score"));
            done = true;
            nextLevel.gameObject.SetActive(true);
        }


    }

    //Reset score, and go back to main menu
    private void gameOver()
    {
        if (timeRemaining == 0 & !done) 
        {
            //Debug.Log("Didn't )
            PlayerPrefs.SetInt("score", 0);
            SceneManager.LoadScene("MainMenu");
        }
    }
}
