using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    System.Random rand = new System.Random();
    int num = -1;

    // Start is called before the first frame update
    void Start()
    {
        num = rand.Next(0,5);   //random int 0 to 4
    }

    public void next()
    {
        Debug.Log("" + num);
        SceneManager.LoadScene(num);
    }
}
