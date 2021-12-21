using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerPrefs.SetInt("score", PlayerPrefs.GetInt("score")+1);
            PlayerPrefs.Save();
        }
    }
}
