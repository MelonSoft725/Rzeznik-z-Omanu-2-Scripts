using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KropkaScript : MonoBehaviour
{

    public Transform target;



    // Start is called before the first frame update
    void Start()
    {

        if (GameObject.FindGameObjectWithTag("Player"))
        {

            target = GameObject.FindGameObjectWithTag("Player").transform;

        }

    }

    // Update is called once per frame
    void Update()
    {

        if (BossHP.cooldown == 2f)
        {
            transform.position = target.position;
        } else
        {

        }


        
    }
}
