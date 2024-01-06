using HealthTutorial;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossPocisk1Script : MonoBehaviour
{
    [Range(1, 10)]
    [SerializeField] private float speed = 12f;

    [Range(1, 10)]
    [SerializeField] private float lifeTime = 3f;

    static public int damage = 1;

    private Rigidbody2D rb;

    public Transform firingPoint;

    [SerializeField] ParticleSystem ps;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Destroy(gameObject, lifeTime);



        firingPoint.Rotate(new Vector3(0, 0, BossHP.obrot));

        BossHP.obrot++;

        firingPoint = GameObject.FindGameObjectWithTag("wazne").transform;

        transform.position = firingPoint.position;
        transform.rotation = firingPoint.rotation;
    }



    private void FixedUpdate()
    {
        rb.velocity = transform.up * speed;
        Physics2D.IgnoreLayerCollision(10, 11);
        Physics2D.IgnoreLayerCollision(11, 11);


    }


    public void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.CompareTag("bullet"))
        {


            Destroy(other.gameObject);
            Destroy(gameObject);


        }

        if (other.gameObject.CompareTag("border"))
        {



            Destroy(gameObject);


        }

        Vector3 location = transform.position;
        ps.transform.position = location;
        Instantiate(ps);


    }

   
}


