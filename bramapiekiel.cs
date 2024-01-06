using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bramapiekiel : MonoBehaviour
{
    public GameObject ccc;
    public GameObject BramaPiekiel;
    static public int BossStart = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (KluczPickUp.klucz == 0)
        {
            if (other.CompareTag("Player"))
            {

                TogglePieklo();
            }
        } else
        {

            Destroy(BramaPiekiel.gameObject);
            BossStart = 1;

        }








        
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (KluczPickUp.klucz == 0)
        {
            if (other.CompareTag("Player"))
            {

                TogglePieklo();
            }
        }
        else
        {

            Destroy(BramaPiekiel.gameObject);


        }
    }


    public void TogglePieklo()
    {


        Debug.Log("pyrpyrpyur");
        ccc.SetActive(!ccc.activeSelf);








    }


}
