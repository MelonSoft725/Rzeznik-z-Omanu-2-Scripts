using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KaczkaScript : MonoBehaviour
{
    static public int kaczka = 0;

    public GameObject item;
    public GameObject to;

    int q = 0;
    private float speed = -4f;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (q == 0)
        {
            StartCoroutine(Czekanie());
        }
        

    }

    IEnumerator Czekanie()
    {
        q = 1;
        int a = Random.Range(1, 360);

        transform.Rotate(0, 0, a);
        
        yield return new WaitForSeconds(2f);

        q = 0;
    }


    private void FixedUpdate()
    {
        rb.velocity = transform.right * speed;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            item.SetActive(true);
            Destroy(to);
            kaczka = 1;
        }else if (other.gameObject.CompareTag("bullet"))
        {

            Destroy(to);

        }
        

    }


}
