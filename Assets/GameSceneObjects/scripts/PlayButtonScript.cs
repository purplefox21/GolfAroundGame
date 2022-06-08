using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onPlayClick()
    {
        PlayerPrefs.SetInt("Level1Open", 1);
        int lastLevelIndex = 0;
        for (int i = 1; i < 21; i++)
        {

            if (PlayerPrefs.GetInt("Level" + i + "Open") == 1)
            {
                lastLevelIndex = lastLevelIndex + 1;
            }

        }

        GoLevel(lastLevelIndex);
    }
    public void GoLevel(int levelName)
    {

        SceneManager.LoadScene(levelName);

    }
}

