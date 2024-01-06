using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StachuTrigger : MonoBehaviour
{
    public GameObject Dialog;
    public GameObject e;

    public int q = 0;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {



            if(q == 1)
            {

                poruszaniesie.CanMove = false;

                TriggerE.e = 0;

                Dialog.SetActive(true);
            }

            


        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {

            e.SetActive(true);

            TriggerE.e = 1;

            q = 1;

            

        }


    }



    private void OnTriggerExit2D(Collider2D other)
    {

        

        if (other.CompareTag("Player"))
        {
            q = 0;

            e.SetActive(false);

            TriggerE.e = 0;
        }
    }



    
}
