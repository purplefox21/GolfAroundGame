using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using EZCameraShake;

public class DeathScript : MonoBehaviour
{
    public GameObject ball;
    public ParticleSystem PrtclSysytm;
    

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
            

            Destroy(ball);

            CameraShaker.Instance.ShakeOnce(4f, 2f, .1f, 3f);

            Instantiate(PrtclSysytm, ball.transform.position, Quaternion.identity);

            StartCoroutine(delay());

            PlayerPrefs.SetInt("Level" + LevelNumber + "Stars", 0);

            int a = PlayerPrefs.GetInt("Death");

            a++;

            PlayerPrefs.SetInt("Death", a);


        }
    }


   public IEnumerator delay()
    {

        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
       
    }



}
