using HealthTutorial;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wroglev2 : MonoBehaviour
{
    public Transform target;
    public float speed = 3f;
    public float rotateSpeed = 0.5f;
    private Rigidbody2D rb;

    int zmienna = 0;

    [SerializeField] private GameObject ps;
    [SerializeField] private GameObject ps1;


    int hp = 4;


    private HealthSystem healthSystem;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    private void Update()
    {

        if (MurBerlinskiTrigger.browar == 1)
        {
            Destroy(gameObject);
            
        }



        if (!target)
        {
            GetTarget();
        }
        else
        {
            RotateTowardsTarget();

        }


    }



    private void FixedUpdate()
    {
        rb.velocity = transform.up * speed;
    }

    private void RotateTowardsTarget()
    {
        Vector2 targetDirection = target.position - transform.position;
        float angle = Mathf.Atan2(targetDirection.y, targetDirection.x) * Mathf.Rad2Deg - 90f;
        Quaternion q = Quaternion.Euler(new Vector3(0, 0, angle));
        transform.localRotation = Quaternion.Slerp(transform.localRotation, q, rotateSpeed);

    }


    private void GetTarget()
    {
        if (GameObject.FindGameObjectWithTag("Player"))
        {

            target = GameObject.FindGameObjectWithTag("Player").transform;
        }
    }




    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            Vector3 location = transform.position;
            ps.transform.position = location;
            Instantiate(ps);

            target = null;
            Destroy(gameObject);
            

        }
        else if (other.gameObject.CompareTag("bullet"))
        {
            hp = hp - pocisk.damage;
            Destroy(other.gameObject);

            if (hp <= 0)
            {
                Vector3 location = transform.position;
                ps.transform.position = location;
                Instantiate(ps);

                Destroy(other.gameObject);
                Destroy(gameObject);
                
                scoreScript.gold = scoreScript.gold + 2;
            }



        }
        else if (other.gameObject.CompareTag("naszarakieta"))
        {
            hp = hp - Rocket.Damage;
            Destroy(other.gameObject);

            if (hp <= 0)
            {
                Vector3 location = transform.position;
                ps.transform.position = location;
                Instantiate(ps);

                Destroy(other.gameObject);
                Destroy(gameObject);

                scoreScript.gold = scoreScript.gold + 2;
            }



        }
        else if (other.gameObject.CompareTag("border2"))
        {
            
            


        }
        else if (other.gameObject.CompareTag("tornado"))
        {

            hp = hp - TornadoScript.damage;


            if (hp <= 0)
            {
                Vector3 location = transform.position;
                ps.transform.position = location;
                Instantiate(ps);


                Destroy(gameObject);
                
            }





        }

        if (other.gameObject.CompareTag("miecz"))
        {
            


                if (Input.GetMouseButton(0))
                {

                    Vector3 direction =(transform.position - target.position).normalized;

                    rb.AddForce(direction * 10);

                    hp = hp - MieczScript.damage;
                    Vector3 location = transform.position;
                    ps1.transform.position = location;
                    Instantiate(ps1);

                    if (hp <= 0)
                    {
                        //Vector3 location = transform.position;
                        ps.transform.position = location;
                        Instantiate(ps);


                        Destroy(gameObject);
                        scoreScript.gold = scoreScript.gold + 2;
                    }

                   

                }
            

            





        }


    }

    private void OnCollisionExit2D(Collision2D other)
    {

        if (other.gameObject.CompareTag("miecz"))
        {

            zmienna = 0;


        }
    }
}
