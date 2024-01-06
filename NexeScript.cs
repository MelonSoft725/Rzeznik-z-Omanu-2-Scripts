using HealthTutorial;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NexeScript : MonoBehaviour
{
    public GameObject item;
    static public int Nexe = 0;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            item.SetActive(true);

            HealthSystem.health++;
            HealthSystem.maxHealth++;
            Nexe = 1;
            Destroy(gameObject);
        }
    }
}
