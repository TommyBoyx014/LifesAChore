using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("trigger");
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("end level");
            PlayerPrefs.SetInt("score", PlayerPrefs.GetInt("score")+1);
        }
    }
}
