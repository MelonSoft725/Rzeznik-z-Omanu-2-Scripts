using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class Kapibara : MonoBehaviour
{
    [SerializeField] private float lifeTimee = 2f;

    void Start()
    {
        Destroy(gameObject, lifeTimee);
    }


    void Update()
    {
        

        
    }
}
