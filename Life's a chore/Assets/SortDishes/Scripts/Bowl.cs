using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bowl : MonoBehaviour
{
    Material mat;
    public int rand = ItemSpawner.rand;
    System.Random randDirty = new System.Random();
    public int dirty = 0;


    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<MeshRenderer>().material.SetColor("_Color", Color.white);
        dirty = randDirty.Next(1, 3);
        switch (dirty)
        {
            case 1: //dirty
                this.GetComponent<MeshRenderer>().material.SetColor("_Color", Color.blue);
                break;
            case 2: //clear
                this.GetComponent<MeshRenderer>().material.SetColor("_Color", Color.white);
                break;
        }

}

// Update is called once per frame
void Update()
    {

        switch (dirty)
        {
            case 1: //dirty                 dish washer N , cabinet M
                if (Input.GetKeyDown(KeyCode.M))
                {
                    Debug.Log("Wrong!");
                    for (float i = 0f; i < 2f; i += .1f)
                    {
                        this.gameObject.transform.localPosition = new Vector3(-.1f, 0f, 0f);
                    }
                    Destroy(gameObject);
                }
                if (Input.GetKeyDown(KeyCode.N))
                {
                    Debug.Log("Right!");
                    for (float i = 0f; i < 2f; i += .1f)
                    {
                        this.gameObject.transform.localPosition = new Vector3(.1f, 0f, 0f);
                    }
                    Destroy(gameObject);
                }
                break;


            case 2:
                if (Input.GetKeyDown(KeyCode.M))
                {
                    Debug.Log("Right!");
                    for (int i = 0; i < 5; i++)
                    {
                        this.gameObject.transform.localPosition = new Vector3(-.1f, 0f, 0f);
                    }
                    Destroy(gameObject);
                }
                if (Input.GetKeyDown(KeyCode.N))
                {
                    Debug.Log("Wrong!");
                    for (float i = 0f; i < 2f; i += .1f)
                    {
                        this.gameObject.transform.localPosition = new Vector3(.1f, 0f, 0f);
                    }
                    Destroy(gameObject);
                }
                break;



        }
    }


}