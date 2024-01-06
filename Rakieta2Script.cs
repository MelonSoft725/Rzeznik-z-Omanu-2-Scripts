using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rakieta2Script : MonoBehaviour
{
    [Range(1, 12)]
    [SerializeField] private float speed = 12f;

    [Range(1, 10)]
    [SerializeField] private float lifeTime = 3f;

    public float rotateSpeed = 0.9f;

    private Rigidbody2D rb;

    public Transform Respawn;
    public Transform target;

    [SerializeField] ParticleSystem ps;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        


        Respawn = GameObject.FindGameObjectWithTag("rakieta2").transform;






        transform.position = Respawn.position;
        transform.rotation = Respawn.rotation;
    }

    private void FixedUpdate()
    {
        rb.velocity = transform.up * speed;
        Physics2D.IgnoreLayerCollision(10, 11);
        Physics2D.IgnoreLayerCollision(11, 11);


    }


    // Update is called once per frame
    void Update()
    {

        if (!target)
        {
            GetTarget();
        }
        else
        {
            RotateTowardsTarget();

        }

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

        if (other.gameObject.CompareTag("bullet"))
        {


            Destroy(other.gameObject);
            Destroy(gameObject);


        }

        if (other.gameObject.CompareTag("border"))
        {



            Destroy(gameObject);


        }




    }

}
