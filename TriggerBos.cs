using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBos : MonoBehaviour
{
    int licznik = 0;

    [SerializeField] private GameObject TimeLine;
    [SerializeField] private GameObject czarny;
    [SerializeField] private GameObject boss1;
    [SerializeField] private GameObject boss2;
    [SerializeField] private GameObject boss21;
    [SerializeField] private GameObject poziomki;

    public GameObject ui1;
    public GameObject ui2;
    public GameObject ui3;
    public GameObject ui4;

    private void Update()
    {
        if (1 == licznik)
        {
            czarny.SetActive(false);
            boss1.SetActive(false);
            boss2.SetActive(true);
            boss21.SetActive(true);
            poziomki.SetActive(true);

            ui1.SetActive(true);
            ui2.SetActive(true);
            ui3.SetActive(true);
            ui4.SetActive(true);
        }

    }

    IEnumerator Licznik()
    {
        yield return new WaitForSecondsRealtime(6f);
        licznik = 1;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {


        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(Licznik());
            TimeLine.SetActive(true);
            czarny.SetActive(true);

            ui1.SetActive(false);
            ui2.SetActive(false);
            ui3.SetActive(false);
            ui4.SetActive(false);

        }



    }
}
