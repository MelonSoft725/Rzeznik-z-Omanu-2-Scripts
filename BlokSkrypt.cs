using HealthTutorial;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlokSkrypt : MonoBehaviour
{
    public Transform tar;

    static public int kedzior = 0;

    public GameObject item;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = tar.position;

      transform.Rotate(new Vector3(0, 0, 1));






    }

    

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (BossHP.boss_dead == 1)
        {
            if (other.CompareTag("Player"))
            {
                kedzior = 1;

                HealthSystem.maxHealth++;
                HealthSystem.health++;

                Destroy(gameObject);

            }
        }

        
    }


    


}
