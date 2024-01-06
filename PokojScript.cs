using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokojScript : MonoBehaviour
{
    public GameObject Pionowe;
    public GameObject Poziome;
    public GameObject Wrogowie;


    public GameObject b;
    public GameObject c;
    public GameObject d;
    public GameObject e;
    public GameObject f;

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
            if (b == null)
            {
                if (c == null)
                {
                    if (d == null)
                    {

                        if (e == null)
                        {

                            if (f == null)
                            {

                                poziom = true;
                            }
                        }
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
            Destroy(gameObject);
        }




    }

    IEnumerator Czas()
    {
        yield return new WaitForSecondsRealtime(0.1f);
        a = 1;
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if(poziom == false)
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
