using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KaoScript : MonoBehaviour
{

    public GameObject item;
    public GameObject Przeciwny;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            item.SetActive(true);
            MieczScript.damage = 3;
            TornadoScript.damage = 7;

            Destroy(Przeciwny);
            Destroy(gameObject);
        }
    }

}
