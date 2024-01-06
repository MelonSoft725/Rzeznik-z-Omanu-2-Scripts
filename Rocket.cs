using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    [Range(1, 12)]
    [SerializeField] private float speed = 12f;

    [Range(1, 10)]
    [SerializeField] private float lifeTime = 3f;

    public float rotateSpeed = 0.9f;

    private Rigidbody2D rb;

    private Vector2 mousePos;
    public Transform target;

    [SerializeField] ParticleSystem ps;
    static public int Damage = 8;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();


        
        






        
    }

    private void FixedUpdate()
    {
        rb.velocity = transform.up * speed;

        transform.rotation = target.rotation;

        Physics2D.IgnoreLayerCollision(7, 8);
        Physics2D.IgnoreLayerCollision(8, 8);


        

    }


    // Update is called once per frame
    void Update()
    {

        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        float angle = Mathf.Atan2(mousePos.y - transform.position.y, mousePos.x -
        transform.position.x) * Mathf.Rad2Deg - 90f;

        transform.localRotation = Quaternion.Euler(0, 0, angle);

    }



    

    

    public void OnCollisionEnter2D(Collision2D other)
    {

        Vector3 location = transform.position;
        ps.transform.position = location;
        Instantiate(ps);
        Destroy(gameObject);


        if (other.gameObject.CompareTag("border"))
        {



            Destroy(gameObject);


        }




    }
}
