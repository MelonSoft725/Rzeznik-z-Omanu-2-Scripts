using HealthTutorial;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProstakerScirp : MonoBehaviour
{
    public GameObject item;
    
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Instantiate(item);
            item.SetActive(true);

            
            HealthSystem.health++;
            HealthSystem.maxHealth++;
            
            Destroy(gameObject);
        }
    }
}
