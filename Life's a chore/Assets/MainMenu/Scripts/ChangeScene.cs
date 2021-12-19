using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    System.Random rand = new System.Random();
    int num = -1;

    public void next()
    {
        num = rand.Next(0, 4);   //random int 0 to 3
        Debug.Log("" + num);
        switch (num)
        {
            case 0:
                SceneManager.LoadScene("MowLawn");
                break;
            case 1:
                SceneManager.LoadScene("SortDishes");
                break;
            case 2:
                SceneManager.LoadScene("PumpTire");
                break;
            case 3:
                SceneManager.LoadScene("GetInside");
                break;
            default:
                break;
        }

    }
}
