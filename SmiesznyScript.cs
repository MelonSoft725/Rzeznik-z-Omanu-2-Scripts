using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public class SmiesznyScript : MonoBehaviour
{



    public Text smieszny_napis;


    






    // Start is called before the first frame update
    void Start()
    {
        int num = UnityEngine.Random.Range(0, 8);


        if (num == 0)
        {
            smieszny_napis.text = "gg ez";
        }
        else if (num == 1)
        {
            smieszny_napis.text = "''Winogrona czerwone 40% taniej 5,99 za kilogram'' - Autor nieznany";

        }
        else if (num == 2)
        {
            smieszny_napis.text = "Zginales, sadeg";
        }
        else if (num == 3)
        {
            smieszny_napis.text = "...---...";
        }
        else if (num == 4)
        {
            smieszny_napis.text = "''nigdy nie lekcewaz mocy rogalika swietomarcinskiego'' - Mieszkaniec poznania";
        }
        else if (num == 5)
        {
            smieszny_napis.text = "Jungle Diff";
        }
        else if (num == 6)
        {
            smieszny_napis.text = "Albion online to sandbox MMO RPG w ktorym to ty piszesz wlasna historie zamiast podazac wytyczona sciezka ";
        }
        else if (num == 7)
        {
            smieszny_napis.text = "Nie biez sie do walki jesli nie jestes w stanie jej wygrac ";
        }

    }






    // Update is called once per frame
    void Update()
    {

    }
}


