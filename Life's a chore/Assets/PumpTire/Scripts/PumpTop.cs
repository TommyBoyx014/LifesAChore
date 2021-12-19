using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PumpTop : MonoBehaviour
{
    Material mat;
    int upDown = 0;
    int tirePressure = 0;
    int kHit = 0;
    int jHit = 0;
    bool complete = false;
    public Tire tire;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
        if (!complete)
        {
            if (tirePressure == 25)
            {
                complete = true;
            }

            if (Input.GetKeyDown(KeyCode.K))
            {
                if (upDown == 0)
                {
                    gameObject.transform.Translate(Vector3.up);
                    upDown = 1;
                }
                kHit++;
                jHit = 0;
                if (kHit == 2)
                {
                    tirePressure = 0;
                    kHit = 0;
                }
            }
            if (Input.GetKeyDown(KeyCode.J))
            {
                if (upDown == 1)
                {
                    gameObject.transform.Translate(Vector3.down);
                    upDown = 0;
                    tirePressure++;
                }
                jHit++;
                kHit = 0;
                if (jHit == 2)
                {
                    tirePressure = 0;
                    jHit = 0;
                }

                if (tirePressure == 10)
                {
                    tire.changeSize();
                }
                if (tirePressure == 20)
                {
                    tire.changeSize();
                }
                if (tirePressure == 25)
                {
                    tire.changeSize();
                }
            }


            Debug.Log(tirePressure);

           

        }
        else
        {
            Debug.Log("DONE");
            //do something to UI
        }

    }
}
