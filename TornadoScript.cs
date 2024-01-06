using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TornadoScript : MonoBehaviour
{
    [SerializeField] private GameObject ps;





    [Range(1, 20)]
    [SerializeField] private float speed = 16f;

    [Range(1, 10)]
    [SerializeField] private float lifeTime = 3f;

    static public int damage = 6;

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
        Physics2D.IgnoreLayerCollision(8, 8);



    }




    private void OnCollisionEnter2D(Collision2D other)
    {




        
         Vector3 location = transform.position;
         ps.transform.position = location;
         Instantiate(ps);
        

        if (other.gameObject.CompareTag("EnemyBullet"))
        {
            Destroy(other.gameObject);
        }


    }

}
