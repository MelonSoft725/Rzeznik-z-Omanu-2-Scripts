using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KaczkaScript1 : MonoBehaviour
{

    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        transform.position = target.position + target.TransformDirection(new Vector3(0, 1, 0));

    }
}
