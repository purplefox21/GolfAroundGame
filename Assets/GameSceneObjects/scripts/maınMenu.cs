using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class maınMenu : MonoBehaviour
{
   

    // Start is called before the first frame update
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void RestartLevel()
    {
        string LevelNumber = SceneManager.GetActiveScene().buildIndex.ToString();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        PlayerPrefs.SetInt("Level" + LevelNumber + "Stars", 0);

    }
    public void GoHome()
    {
        SceneManager.LoadScene(0);
       
    }

    public void SkipLevel()
    {
        int LevelNumberUp = SceneManager.GetActiveScene().buildIndex + 1;
        PlayerPrefs.SetInt("Level"+ LevelNumberUp + "Open", 1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        int a =PlayerPrefs.GetInt("SkipCount");

        a++;

        PlayerPrefs.SetInt("SkipCount", a);

    }

}
