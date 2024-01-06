using HealthTutorial;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zuz: MonoBehaviour
{
    public GameObject item;
    public GameObject Przeciwny;
    static public int zuzia = 0;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            item.SetActive(true);

            zuzia = 1;
            HealthSystem.health++;
            HealthSystem.maxHealth++;
            Destroy(Przeciwny);
            Destroy(gameObject);
        }
    }
}
