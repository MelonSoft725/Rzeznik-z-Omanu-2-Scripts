using HealthTutorial;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScreen : MonoBehaviour
{

    public GameObject death;

    static public HealthSystem healthSystem;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (healthSystem.Health <= 0)
        {
            death.SetActive(death.activeSelf);
        }


    }
}
