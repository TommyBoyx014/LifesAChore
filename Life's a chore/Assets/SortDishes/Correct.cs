using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Correct : MonoBehaviour
{
    public int correctCount;
    void Start()
    {
        
    }
    public void addCorrect()
    {
        correctCount++;
    }
    // Update is called once per frame
    void Update()
    {
        if(correctCount == 10)
        {
            Debug.Log("Complete!");
        }
    }
}
