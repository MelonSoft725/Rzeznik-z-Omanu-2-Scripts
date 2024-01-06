using HealthTutorial;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wrog1 : MonoBehaviour
{
    public Transform target;
    public float speed = 3f;
    public float rotateSpeed = 0.0025f;
    private Rigidbody2D rb;

    [SerializeField] private GameObject ps;

    static public int eee = 0;
    

    private HealthSystem healthSystem;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    private void Update()
    {

        if(MurBerlinskiTrigger.browar == 1)
        {
            Destroy(gameObject);
            wrog1.eee = wrog1.eee - 1;
            if (wrog1.eee < 0)
            {
                wrog1.eee = 0;
            }
        }



        if (!target)
        {
            GetTarget();
        } else
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
            wrog1.eee = wrog1.eee - 1;

        }
        else if (other.gameObject.CompareTag("bullet"))
        {
            Vector3 location = transform.position;
            ps.transform.position = location;
            Instantiate(ps);

            Destroy(other.gameObject);
            Destroy(gameObject);
            wrog1.eee = wrog1.eee - 1;
            scoreScript.gold = scoreScript.gold + 1;

        }
        else if (other.gameObject.CompareTag("border"))
        {
            Vector3 location = transform.position;
            ps.transform.position = location;
            Instantiate(ps);

            
            Destroy(gameObject);
            wrog1.eee = wrog1.eee - 1;
            

        }




    }

}


