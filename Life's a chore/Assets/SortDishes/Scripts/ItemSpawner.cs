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
    public Plate dirtyPlate;
    public Fork dirtyFork;
    public Spoon dirtySpoon;
    public Bowl dirtyBowl;
    public Cup dirtyCup;
    public Knife dirtyKnife;
    public Knife knife_prefab;


    System.Random itemPicker = new System.Random();
    System.Random randDirty = new System.Random();
    public int dirty = 0;
    public int gameCount;
    int activePrefab = 0;
    public static int rand = 0;
    public GameObject Indicator;
    Plate plate;
    Cup cup;
    Bowl bowl;
    Fork fork;
    Spoon spoon;
    Knife knife;

    // Start is called before the first frame update
    void Start()
    {
       rand = itemPicker.Next(1, 7);
        dirty = randDirty.Next(1, 3);
        
    }

   
    IEnumerator StartGame(int dirty)
    {
        rand = itemPicker.Next(1, 7);
        

        switch (rand)
        {
            case 1:
                switch (dirty)
                {
                    case 1:
                        plate = Instantiate(plate_prefab, this.transform.position, Quaternion.Euler(-90, 0, 0));
                        break;
                    case 2:
                        plate = Instantiate(dirtyPlate, this.transform.position, Quaternion.Euler(-90, 0, 0));
                        break;
                }
                break;
            case 2:
                switch (dirty)
                {
                    case 1:
                        spoon = Instantiate(spoon_prefab, this.transform.position, Quaternion.Euler(-90, 0, 0));
                        break;
                    case 2:
                        spoon = Instantiate(dirtySpoon, this.transform.position, Quaternion.Euler(-90, 0, 0));
                        break;
                }
                break;
            case 3:
                switch (dirty)
                {
                    case 1:
                        fork = Instantiate(fork_prefab, this.transform.position, Quaternion.Euler(-90, 0, 0));
                        break;
                    case 2:
                        fork = Instantiate(dirtyFork, this.transform.position, Quaternion.Euler(-90, 0, 0));
                        break;
                }
                break;
            case 4:
                switch (dirty)
                {
                    case 1:
                        bowl = Instantiate(bowl_prefab, this.transform.position, Quaternion.Euler(-90, 0, 0));
                        break;
                    case 2:
                        bowl = Instantiate(dirtyBowl, this.transform.position, Quaternion.Euler(-90, 0, 0));
                        break;
                }
                break;
            case 5:
                switch (dirty)
                {
                    case 1:
                        cup = Instantiate(cup_prefab, this.transform.position, Quaternion.Euler(0, 0, 0));
                        break;
                    case 2:
                        cup = Instantiate(dirtyCup, this.transform.position, Quaternion.Euler(0, 0, 0));
                        break;
                }
                break;
            case 6:
                switch (dirty)
                {
                    case 1:
                        knife = Instantiate(knife_prefab, this.transform.position, Quaternion.Euler(90, -90, 0));
                        break;
                    case 2:
                        knife = Instantiate(dirtyKnife, this.transform.position, Quaternion.Euler(90, -90, 0));
                        break;
                }

                break;
        }        
            yield return null;
    }

    

    // Update is called once per frame
    void Update()
    {
        if (!(gameCount == 7))
        {
            if (GameObject.Find(Indicator.name + "(Clone)"))
            {
                gameCount++;
                Destroy(GameObject.Find(Indicator.name + "(Clone)"));
                Debug.Log("working");
                Debug.Log("Correct: " + gameCount);
            }
            if (gameCount == 7)
            {
                //end game
                PlayerPrefs.SetInt("score", PlayerPrefs.GetInt("score") + 1);
                Debug.Log("Done!");
            }
            if (Input.GetKeyDown(KeyCode.N) || Input.GetKeyDown(KeyCode.M))
            {
               
                dirty = randDirty.Next(1, 3);
                if (spoon == null && fork == null && plate == null && bowl == null && cup == null && knife == null)
                {
                    activePrefab = 0;
                }
                activePrefab++;
                if (activePrefab == 1)
                {

                    StartCoroutine(StartGame(dirty));
                }

            }
           
        }
    }
   
}
