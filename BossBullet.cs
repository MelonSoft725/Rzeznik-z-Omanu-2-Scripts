using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossBullet : MonoBehaviour
{
    [Range(1, 10)]
    [SerializeField] private float speed = 0.1f;

    [Range(1, 10)]
    [SerializeField] private float lifeTime = 3f;

    static public int damage = 1;

    private Rigidbody2D rb;

    
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Destroy(gameObject, lifeTime);
        StartCoroutine(Licznik());
    }

    private void FixedUpdate()
    {
        rb.velocity = transform.up * speed;
        Physics2D.IgnoreLayerCollision(10, 11);
        Physics2D.IgnoreLayerCollision(11, 11);
        
    }

    IEnumerator Licznik()
    {
        
        yield return new WaitForSecondsRealtime(0.1f);
        speed += 1f;
        StartCoroutine(Licznik());


    }


    public void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.CompareTag("bullet"))
        {


            Destroy(other.gameObject);
            Destroy(gameObject);


        }

        if (other.gameObject.CompareTag("border2"))
        {
            Destroy(gameObject);
        }


        if (other.gameObject.CompareTag("Player"))
        {
            BossAdin.BossHealth2 += 10f;

            
        }

    }
}
