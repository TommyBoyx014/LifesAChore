using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fork : MonoBehaviour
{

    public Vector3 movementTarget = new Vector3(0.2872189f, -0.127385f, -2.43f);
    public int dirty = 0;
    // Start is called before the first frame update
    void Start()
    {

        movementTarget = new Vector3(0.2872189f, -0.127385f, -2.43f);

    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.tag == "Dirty")
        {
            dirty = 1;
        }
        else
        {
            dirty = 2;
        }
        switch (dirty)
        {

            case 1: //dirty                 dish washer N , cabinet M
                if (Input.GetKeyDown(KeyCode.M))
                {
                    Debug.Log("Wrong!");
                    movementTarget = new Vector3(5f, -0.127385f, -2.43f);
                }
                if (Input.GetKeyDown(KeyCode.N))
                {
                    Debug.Log("Right!");

                    movementTarget = new Vector3(-5f, -0.127385f, -2.43f);
                }
                break;


            case 2:
                if (Input.GetKeyDown(KeyCode.M))
                {
                    Debug.Log("Right!");

                    movementTarget = new Vector3(5f, -0.127385f, -2.43f);
                }
                if (Input.GetKeyDown(KeyCode.N))
                {
                    Debug.Log("Wrong!");

                    movementTarget = new Vector3(-5f, -0.127385f, -2.43f);
                }
                break;

        }
        this.transform.Translate((movementTarget - this.transform.position).normalized * 20 * Time.deltaTime, Space.World);
        if (gameObject.transform.position.x < -5f || gameObject.transform.position.x > 5f)
        {
            Destroy(gameObject);
            movementTarget = new Vector3(0.2872189f, -0.127385f, -2.43f);
        }
    }


}
