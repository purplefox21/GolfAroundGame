﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScript : MonoBehaviour
{
    public GameObject WinPanel;

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
        int LevelNumber = SceneManager.GetActiveScene().buildIndex;


        int LevelNumberUP = LevelNumber + 1;

        if (collision.tag== "Ball")
        {
            WinPanel.SetActive(true);

            PlayerPrefs.SetInt("Level" + LevelNumberUP + "Open",1);

            if (PlayerPrefs.GetInt("Level" + LevelNumber + "Score")< PlayerPrefs.GetInt("Level" + LevelNumber + "Stars"))
            {
                PlayerPrefs.SetInt("Level" + LevelNumber + "Score", PlayerPrefs.GetInt("Level" + LevelNumber + "Stars"));
            }
            

        }

    }
}
