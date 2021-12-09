using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    private int score = 0;
    public Text scoreText;
    public Text timeText;

    private void Update()
    {
        scoreText.text = ""+score;
        timeText.text = "" + Time.deltaTime;
    }
}
