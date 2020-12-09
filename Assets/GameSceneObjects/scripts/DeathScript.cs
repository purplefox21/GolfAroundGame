using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScript : MonoBehaviour
{
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        string LevelNumber = SceneManager.GetActiveScene().buildIndex.ToString();
        if (collision.tag == "Ball")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            PlayerPrefs.SetInt("Level" + LevelNumber + "Stars", 0);
        }
    }

}
