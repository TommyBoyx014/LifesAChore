using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{

    public Plate plate_prefab;
    public Fork fork_prefab;
    public Spoon spoon_prefab;
    public Bowl bowl_prefab;
    public Cup cup_prefab;
    System.Random itemPicker = new System.Random();

    int activePrefab = 0;
    public static int rand = 0;

    Plate plate;
    Cup cup;
    Bowl bowl;
    Fork fork;
    Spoon spoon;

    // Start is called before the first frame update
    void Start()
    {
       rand = itemPicker.Next(1, 6);        
    }

    IEnumerator StartGame(int rand)
    {
        switch (rand)
        {
            case 1:
                plate = Instantiate(plate_prefab, this.transform.position, Quaternion.Euler(-90, 0, 0));
                break;
            case 2:
                bowl = Instantiate(bowl_prefab, this.transform.position, Quaternion.Euler(-90, 0, 0));
                break;
            case 3:
                fork = Instantiate(fork_prefab, this.transform.position, Quaternion.Euler(-80, 0, 0));
                break;
            case 4:
                spoon = Instantiate(spoon_prefab, this.transform.position, Quaternion.Euler(-90, 0, 0));
                break;
            case 5:
                cup = Instantiate(cup_prefab, this.transform.position, this.transform.rotation);
                break;
        }        
            yield return null;
    }

    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N) || Input.GetKeyDown(KeyCode.M))
        {
            if (spoon == null && fork == null && plate == null && bowl == null && cup == null)
            {
                activePrefab = 0;
            }
            activePrefab++;
            if (activePrefab == 1)
            {
                rand = itemPicker.Next(1, 6);
                StartCoroutine(StartGame(rand));
            }

        }
        
       
            
    }
}