using HealthTutorial;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KwordScript : MonoBehaviour
{
    [SerializeField] private CanvasGroup myUIGroup;

    [SerializeField] private bool fadeIn = false;
    [SerializeField] private bool fadeOut = false;

    public GameObject death;

    int i = 0;

    public void ShowUI()
    {
        fadeIn = true;
    }

    public void HideUI()
    {
        fadeOut = true;

    }

    void ToggleDeath()
    {
        death.SetActive(true);
    }


    private void Update()
    {

        if (HealthSystem.health == 0)
        {
            i = 1;
            fadeIn = true;
        }


        if (i == 1)
        {
            ToggleDeath();
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
                myUIGroup.alpha += Time.deltaTime;
                if (myUIGroup.alpha == 0)
                {
                    fadeOut = false;
                }

            }

        }


    }


}
