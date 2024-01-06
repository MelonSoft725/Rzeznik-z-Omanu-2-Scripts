using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KedziorTrigger : MonoBehaviour
{
    public GameObject item;

    int b = 0;
    static public int c = 0;

    private void Update()
    {

        if (BlokSkrypt.kedzior == 1 && b == 0)
        {
            b = 1;
            StartCoroutine(Time());

        }





    }


    public IEnumerator Time()
    {
        item.SetActive(true);
        yield return new WaitForSecondsRealtime(3f);

        KedziorTrigger.c = 1;
        
        // item.SetActive(false);
        // yield return new WaitForSecondsRealtime(1f);
    }


}
