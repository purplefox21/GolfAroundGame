using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DeathnSkip : MonoBehaviour
{
    public TextMeshProUGUI DEATH;
    public TextMeshProUGUI SKIP;

    // Start is called before the first frame update
    void Start()
    {
        DEATH.text = PlayerPrefs.GetInt("Death").ToString();
        SKIP.text = PlayerPrefs.GetInt("SkipCount").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
