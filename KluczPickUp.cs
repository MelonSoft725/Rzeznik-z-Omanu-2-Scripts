using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KluczPickUp : MonoBehaviour
{
    [SerializeField] private Animator animator;

    public GameObject klucz2;

    static public int trafienie = 0;



    public static int klucz = 0;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            klucz2.SetActive(true);
            Destroy(gameObject);
            klucz = 1;
        }

        
        
        if (other.gameObject.CompareTag("bullet"))
        {
            animator.SetBool("trafienie", true);

            KluczPickUp.trafienie = 1;

        }



        



    }
}
