using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerPre : MonoBehaviour
{
   
    

    // Start is called before the first frame update
    void Start()
    {
        int LevelNumber = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("Level" + LevelNumber + "Stars", 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        int LevelNumber = SceneManager.GetActiveScene().buildIndex;

        if (collision.tag == "Star")
        {
            Destroy(collision.gameObject);

            if (PlayerPrefs.GetInt("Level"+LevelNumber+"Stars")==0)
            {
                PlayerPrefs.SetInt("Level" + LevelNumber + "Stars", 1);
            }
            else if(PlayerPrefs.GetInt("Level" + LevelNumber + "Stars") == 1)
            {
                PlayerPrefs.SetInt("Level" + LevelNumber + "Stars", 2);
            }
            else if (PlayerPrefs.GetInt("Level" + LevelNumber + "Stars") == 2)
            {
                PlayerPrefs.SetInt("Level" + LevelNumber + "Stars", 3);
            }

            

            int number = PlayerPrefs.GetInt("Level" + LevelNumber + "Stars");
            
        }
    }

}
