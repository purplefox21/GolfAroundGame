using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelFader : MonoBehaviour
{
    [SerializeField] bool mFaded = false;
    [SerializeField] float Duration = 2f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Fade", 0, Duration);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.touchCount > 0)
        {
            Destroy(this.gameObject);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Destroy(this.gameObject);
        }
        else if (Input.GetKey(KeyCode.A))
        {

            Destroy(this.gameObject);
        }
        

    }

    public void Fade()
    {
        var canvGroup = GetComponent<CanvasGroup>();

        StartCoroutine(DoFade(canvGroup, canvGroup.alpha, mFaded ? 1 : 0));

        mFaded = !mFaded;
    }
    public IEnumerator DoFade(CanvasGroup canvasGroup, float start, float end)
    {
        float counter = 0f;
        while(counter < Duration)
        {
            counter += Time.deltaTime;
            canvasGroup.alpha = Mathf.Lerp(start, end, counter / Duration);

            yield return null;
        }
    }
}
