using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pokoj2 : MonoBehaviour
{
    public GameObject Pionowe;
    public GameObject Poziome;
    public GameObject Wrogowie;




    public bool poziom = false;

    int a = 0;
    private void Start()
    {
        Wrogowie.SetActive(false);
    }

    private void Update()
    {
        if (a == 1)
        {
            if (GameObject.Find("przeciwnik w lochach1") == null)
            {
                if (GameObject.Find("przeciwnik w lochach2") == null)
                {
                    if (GameObject.Find("pan gzib") == null)
                    {
                        poziom = true;
                    }
                }

            }

        }
        else
        {
            poziom = false;
        }



        if (poziom == true)
        {
            Pionowe.SetActive(false);
            Poziome.SetActive(false);
            Wrogowie.SetActive(false);
        }




    }

    IEnumerator Czas()
    {
        yield return new WaitForSecondsRealtime(0.1f);
        a = 1;
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (poziom == false)
        {



            if (other.gameObject.CompareTag("Player"))
            {

                Pionowe.SetActive(true);
                Poziome.SetActive(true);
                Wrogowie.SetActive(true);

                StartCoroutine(Czas());
            }
        }
    }

}
