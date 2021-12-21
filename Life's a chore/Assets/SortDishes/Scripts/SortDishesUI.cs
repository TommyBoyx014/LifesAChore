using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SortDishesUI : MonoBehaviour
{
    private int score = -1;
    //private int lives = -1;
    [SerializeField] Text scoreText;
    [SerializeField] Text timeText;
    [SerializeField] Button nextLevel;
    private bool timerIsRunning = true;
    private float timeRemaining = 15.0f;

    //[SerializeField] public Text livesText;

    private void Start()
    {
        score = PlayerPrefs.GetInt("score", score); //Get the score from previous game
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

        //if no more grass, increase score 
        if (GameObject.FindGameObjectsWithTag("grass").Length == 1)
        {
            score++;
        }

        //if score changed, enable next button and increase player score
        if (PlayerPrefs.GetInt("score") != score)
        {
            PlayerPrefs.SetInt("score", score);
            PlayerPrefs.Save();
            nextLevel.gameObject.SetActive(true);
        }


    }

    //Reset score, and go back to main menu
    private void gameOver()
    {
        int num = GameObject.FindGameObjectsWithTag("grass").Length;
        if (timeRemaining == 0 & num > 1) //Check if there's still grass
        {
            PlayerPrefs.SetInt("score", 0);
            PlayerPrefs.Save();
            SceneManager.LoadScene("MainMenu");
        }
    }
}
