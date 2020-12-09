using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickTurnScript : MonoBehaviour
{
    public float speed=200;
    public PhysicsMaterial2D a;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, 0, -0.5f) * Time.deltaTime*speed*2);
           // a.bounciness = 0.9f;

        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, 0, 0.5f) * Time.deltaTime*speed*2);

            //a.bounciness = 0.9f;
        }
        else
        {
           // a.bounciness = 0.2f;
        }
       
    }
}