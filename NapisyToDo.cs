using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NapisyToDo : MonoBehaviour
{
    //SpriteRenderer rend;

    public TextMeshProUGUI text;

    int liczba = 0;
    int liczba2 = 0;
    int liczba3 = 0;

    static public int kupiony_item = 0;


    // Start is called before the first frame update
    void Start()
    {
       // rend = GetComponent<SpriteRenderer>();
       // Color c = rend.material.color;
        //c.a = 0f;
        //rend.material.color = c;

        



        startFading();
    }


    IEnumerator FadeInn()
    {
        for (float f = 0.05f; f <= 1; f += 0.05f)
        {
            //Color c = rend.material.color;
           // c.a = f;
           // rend.material.color = c;
            yield return new WaitForSeconds(0.05f);
        }

    }

    public void startFading()
    {
        StartCoroutine("FadeInn");
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButton(0))
        {
            liczba2 = 1;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            liczba3 = 1;
        }


        if (liczba == 0)
        {
            if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.S))
            {
                startFading();
                text.text = "Uzyc Dasha (spacja) podczas ruchu";
                liczba = 1;
            }






        }
        else if (liczba == 1 && liczba3 == 1)
        {
            text.text = "Uzyc broni LPM";
            liczba = 2;


        }
        else if (liczba == 2 && liczba2 == 1)
        {
            startFading();
            text.text = "Kupic cos w sklepie na wschodzie";
            liczba = 3;
        }
        else if (liczba == 3 && NapisyToDo.kupiony_item == 1)
        {
            text.text = "isc na zachodnia wyspe po klucz";
            liczba = 4;
        }
        else if (liczba == 4 && KluczPickUp.klucz == 1)
        {
            text.text = "Przejsc dolnym przejsciem do Szefa Mafii...";
            liczba = 5;
        }
        else if (liczba == 5 && BossHP.boss_dead == 1)
        {
            text.text = "Przejsc przez portal na nowo odblokowanej wyspie";
            liczba = 6;
        }



    }








}

