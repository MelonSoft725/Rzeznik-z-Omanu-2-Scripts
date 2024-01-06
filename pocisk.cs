using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
using UnityEngine.Tilemaps;

public class pocisk : MonoBehaviour
{



    [SerializeField] private GameObject ps;





    [Range(1, 20)]
    [SerializeField] private float speed = 10f;

    [Range(1, 10)]
    [SerializeField] private float lifeTime = 3f;

    static public int damage = 1;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Destroy(gameObject, lifeTime);

    }

    private void Update()
    {

    }



    private void FixedUpdate()
    {
        rb.velocity = transform.up * speed;
        Physics2D.IgnoreLayerCollision(7, 8);



    }



    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("border2"))
        {

            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {

        


        if (other.gameObject.CompareTag("border2"))
        {

            Destroy(gameObject);
        } 
         else
        {
            Vector3 location = transform.position;
            ps.transform.position = location;
            Instantiate(ps);
        }



    }

}
