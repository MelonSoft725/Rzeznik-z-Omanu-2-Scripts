using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BerlinZachodniTrigger : MonoBehaviour
{

    

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {

            if (MurBerlinskiTrigger.browar == 1)
            {
                MurBerlinskiTrigger.browar = MurBerlinskiTrigger.browar - 1;
            }

            if (MurBerlinskiTrigger.browar <= -2)
            {
                MurBerlinskiTrigger.browar = 0;
            }

            if (MurBerlinskiTrigger.browar == 0)
            {

            }

        }
    }






}
