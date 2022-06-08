using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class LevelMenuScript : MonoBehaviour
{
   
    public GameObject namelvl;

    // Start is called before the first frame update
    void Start()
    {

    }


    public void BolumYildizCheck()
    {

        for (int i = 1; i < 21; i++)
        {
            namelvl = null;

            namelvl = GameObject.FindWithTag("lvl" + i);

            if (PlayerPrefs.GetInt("Level" + i + "Open") == 1)
            {
                namelvl.GetComponent<Button>().interactable = true;
            }


            int a = PlayerPrefs.GetInt("Level" + i + "Score");

            for (int k = 0; k < a; k++)
            {
                namelvl.transform.GetChild(0).GetChild(k).gameObject.SetActive(true);
            }
            
        }

    }

    public void quo()
    {

        //Application.Quit();

        //for (int i = 1; i < 21; i++)

        //{
        //    namelvl = null;
        //    namelvl = GameObject.FindWithTag("lvl" + i);
        //    PlayerPrefs.SetInt("Level" + i + "Open", 0);
        //    PlayerPrefs.SetInt("Level" + i + "Score", 0);
        //}

        //PlayerPrefs.SetInt("Level1Open", 1);
        //PlayerPrefs.SetInt("Level1Score", 0);
        //PlayerPrefs.SetInt("SkipCount", 0);
        //PlayerPrefs.SetInt("Death", 0);
    }
    public void GoLevel(int levelName)
    {

        SceneManager.LoadScene(levelName);

    }

    public void Reset()
    {
        for (int i = 1; i < 21; i++)

        {
            namelvl = null;
            namelvl = GameObject.FindWithTag("lvl" + i);
            PlayerPrefs.SetInt("Level" + i + "Open", 0);
            PlayerPrefs.SetInt("Level" + i + "Score", 0);
        }
        PlayerPrefs.SetInt("SkipCount", 0);
        PlayerPrefs.SetInt("Death", 0);
    }
}
