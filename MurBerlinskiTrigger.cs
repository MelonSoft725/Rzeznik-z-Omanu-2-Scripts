using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MurBerlinskiTrigger : MonoBehaviour
{

    static public int browar = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (MurBerlinskiTrigger.browar == 0)
            {
                MurBerlinskiTrigger.browar = MurBerlinskiTrigger.browar + 1;
            }

            if (MurBerlinskiTrigger.browar <= 2)
            {
                MurBerlinskiTrigger.browar = 1;
            }

            if (MurBerlinskiTrigger.browar == 1)
            {

            }


        }
    }

   

}
