using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerE : MonoBehaviour
{

    public static int e = 0;

    public GameObject text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (TriggerE.e == 0)
        {
            text.SetActive(false);
        }
        else if (TriggerE.e == 1) 
        {
            text.SetActive(true);

        }



    }
}
