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
    public Tire tire_0;
    public Tire tire_50;
    public Tire tire_100;

    Tire tire;


    void Start()
    {
        tire = Instantiate(tire_0, new Vector3(0f,3f,-2.6f), this.transform.rotation);
        tire.scaleObj();

    }

    // Update is called once per frame
    void Update()
    {
     
        if (!complete)
        {
            if (tirePressure == 25)
            {
                PlayerPrefs.SetInt("score", PlayerPrefs.GetInt("score") + 1);
                PlayerPrefs.Save();
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

                if (tirePressure == 13)
                {
                    tire.DestroyObj();
                    tire = Instantiate(tire_50, new Vector3(0f, 3f, -2.6f), this.transform.rotation);
                    tire.scaleObj();
                }
                if (tirePressure == 25)
                {
                    tire.DestroyObj();
                    tire = Instantiate(tire_100, new Vector3(0f, 3f, -2.6f), this.transform.rotation);
                    tire.scaleObj();

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
