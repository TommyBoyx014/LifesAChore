using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployRain : MonoBehaviour
{
    public GameObject rainPrefab;
    public float respawnTime = 1.0f;
    private Vector2 screenBounds;

    // Use this for initialization
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(asteroidWave());
    }
    private void spawnEnemy()
    {
        GameObject a = Instantiate(rainPrefab) as GameObject;
        a.transform.position = new Vector3( Random.Range(-screenBounds.x, screenBounds.x), screenBounds.y * -2,0);
    }
    IEnumerator asteroidWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
        }
    }
}