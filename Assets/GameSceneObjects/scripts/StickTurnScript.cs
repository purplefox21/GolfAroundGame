using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StickTurnScript : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.position.x < Screen.width / 2)
            {
                //Move Player Left
                rb.angularVelocity = speed;
            }
            else if (touch.position.x > Screen.width / 2)
            {
                //Move Player Right
                rb.angularVelocity = -speed;
            }
            
        }
        else { rb.angularVelocity = 0; }



        if (Input.GetKey(KeyCode.D))
        {
            rb.angularVelocity = -speed;
        }
        else if (Input.GetKey(KeyCode.A))
        {

            rb.angularVelocity = speed;
        }
        else
        {
            rb.angularVelocity = 0;
        }

        
        if (Input.GetKey(KeyCode.R))
        {
            string LevelNumber = SceneManager.GetActiveScene().buildIndex.ToString();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

            PlayerPrefs.SetInt("Level" + LevelNumber + "Stars", 0);
        }

        
        

    }
}