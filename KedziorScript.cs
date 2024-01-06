using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KedziorScript : MonoBehaviour
{

    [SerializeField] private CanvasGroup myUIGroup;

    [SerializeField] private bool fadeIn = false;
    [SerializeField] private bool fadeOut = false;

    private int zmienna = 0;

    public void ShowUI()
    {
        fadeIn = true;
    }

    public void HideUI()
    {
        fadeOut = true;

    }

    // Start is called before the first frame update
    void Start()
    {

        ShowUI();
        StartCoroutine(Timer());
    }

    IEnumerator Timer()
    {
        yield return new WaitForSecondsRealtime(6f);
        zmienna = 1;
    }

    // Update is called once per frame
    void Update()
    {

        if (zmienna == 1)
        {
            HideUI();
        }



        if (fadeIn)
        {

            if (myUIGroup.alpha < 1)
            {
                myUIGroup.alpha += Time.deltaTime;
                if (myUIGroup.alpha >= 1)
                {
                    fadeIn = false;
                }

            }

        }

        if (fadeOut)
        {

            if (myUIGroup.alpha >= 0)
            {
                myUIGroup.alpha -= Time.deltaTime;
                if (myUIGroup.alpha == 0)
                {
                    fadeOut = false;
                }

            }

        }
    }
}
