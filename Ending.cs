using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ending : MonoBehaviour
{

    public GameObject muzyka;
    public GameObject end1;
    public GameObject end2;

    IEnumerator Koniec()
    {
        yield return new WaitForSecondsRealtime(20f);
        end1.SetActive(false);
        end2.SetActive(false);
        
        muzyka.SetActive(true);
        Application.Quit();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            if (RedScript.secret == 0 )
            {
                muzyka.SetActive(false);
                end1.SetActive(true);
                StartCoroutine(Koniec());

            } else if(RedScript.secret == 1)
            {
                muzyka.SetActive(false);
                end2.SetActive(true);
                StartCoroutine(Koniec());
            }


        }



    }
}
