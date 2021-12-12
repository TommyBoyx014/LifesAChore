using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    private int score = 0;
    [SerializeField] public Text scoreText;
    [SerializeField] public Text timeText;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        scoreText.text = ""+score;
        timeText.text = "" + Time.deltaTime;
    }
}
