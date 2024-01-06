using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;
using TMPro;
using System;
using System.Net.Sockets;

public class skryptdlapudelkawoku : MonoBehaviour
{
    [SerializeField] private float speed = 5f;

    [SerializeField] private GameObject pistolet;
    [SerializeField] private GameObject karabin;
    [SerializeField] private GameObject katana;
    [SerializeField] private GameObject katanaActive;

    [SerializeField] private GameObject Goblin;
    [SerializeField] private GameObject rocket;

    [SerializeField] private GameObject KatanaAnimacja;

    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private GameObject wicher;
    [SerializeField] private Transform firingPoint;
    [Range (0.1f, 1f)]
    [SerializeField] static public float fireRate = 0.5f;

    [SerializeField] private AudioSource ShootSFX;
    [SerializeField] private AudioSource SwordSFX;
    [SerializeField] private AudioSource HasagiSFX;

    public TextMeshProUGUI text;

    Animator animator;
    public float delay = 0.3f;
    public bool canAttack = false;

    int bron = 0;
    bool zmiana = true;
    public bool canShoot = true;
    public bool canGoblin = false;

    public int hasagi = 0;

    //private Rigidbody2D rb;
    private float mx;
    private float my;

    private float fireTimer;

    static public int Maxbron = 1;

    private Vector2 mousePos;


    public Transform circleOrigin;
    public float radius;

    private void Start()
    {
        //rb = GetComponent<Rigidbody2D>();
        animator = KatanaAnimacja.GetComponent<Animator>();
    }

    private void Update()
    {

        
        mx = Input.GetAxisRaw("Horizontal");
        my = Input.GetAxisRaw("Vertical");
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        float angle = Mathf.Atan2(mousePos.y - transform.position.y, mousePos.x -
        transform.position.x) * Mathf.Rad2Deg - 90f;

        transform.localRotation = Quaternion.Euler(0, 0, angle);

        if (Input.GetMouseButton(0) && fireTimer <= 0f)
        {
            //animator.SetTrigger("Attack");
            Shoot();
            MeleeAttack();
            goblin();
            fireTimer = skryptdlapudelkawoku.fireRate;
        } else {

            fireTimer -= Time.deltaTime;

        }


        if (Input.GetKeyDown(KeyCode.Q))
        {

            bron++;

            if (bron > Maxbron)
            {
                bron = 0;
            }

            text.text = "" + bron;

            if (bron == 0 && ShopManager.karabin == 1)
            {
                Goblin.SetActive(false);
                katana.SetActive(false);
                pistolet.SetActive(false);
                karabin.SetActive(true);
                fireRate = 0.3f;
                canShoot = true;
                canAttack = false;
                canGoblin = false;
                katanaActive.SetActive(false);

            }
            else if (bron == 1)
            {
                Goblin.SetActive(false);
                katana.SetActive(false);
                pistolet.SetActive(true);
                karabin.SetActive(false);
                fireRate = 0.5f;
                canShoot = true;
                canAttack = false;
                canGoblin = false;
                katanaActive.SetActive(false);


            }
            else if (bron == 2 && KatanaTrigger.katana == 1)
            {
                Goblin.SetActive(false);
                katana.SetActive(true);
                pistolet.SetActive(false);
                karabin.SetActive(false);
                canShoot = false;
                canAttack = true;
                canGoblin = false;
                katanaActive.SetActive(true);
            }
            else if (bron == 3 && RedScript.foss == 1)
            {
                Goblin.SetActive(true);
                katana.SetActive(false);
                pistolet.SetActive(false);
                karabin.SetActive(false);
                canShoot = false;
                canAttack = false;
                canGoblin = true;
                katanaActive.SetActive(false);
            }
            else
            {
                Goblin.SetActive(false);
                katana.SetActive(false);
                pistolet.SetActive(false);
                karabin.SetActive(false);
                canShoot = false;
                canAttack = false;
                canGoblin = false;
                katanaActive.SetActive(false);

            }
        }


    }



    

    

    private void FixedUpdate()
    {
        //rb.velocity = new Vector2(mx, my).normalized * speed;
    }

    private void Shoot()
    {
        if (canShoot == true)
        {
            ShootSFX.Play();
            Instantiate(bulletPrefab, firingPoint.position, firingPoint.rotation);
        } else if (canAttack == true && canShoot == false && hasagi >= 3) 
        {

            HasagiSFX.Play();
            Instantiate(wicher, firingPoint.position, firingPoint.rotation);
            hasagi = 0;

        }

        
        
    }

    private void goblin()
    {
        if (canGoblin == true)
        {
            ShootSFX.Play();
            Instantiate(rocket, firingPoint.position, firingPoint.rotation);
        }
        
    }

    private void MeleeAttack()
    { 

        if (canAttack == true)
        {
            SwordSFX.Play();
            hasagi++;
            animator.SetTrigger("Attack");
            canAttack = false;
            StartCoroutine(DelayAttack());
        }


    }

    private IEnumerator DelayAttack()
    {
        yield return new WaitForSeconds(delay);
        canAttack = true;
    }


    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Vector3 position = circleOrigin == null ? Vector3.zero : circleOrigin.position;
        Gizmos.DrawWireSphere(position, radius);
    }

    public void DetectColliders()
    {
        foreach (Collider2D collider in Physics2D.OverlapCircleAll(circleOrigin.position, radius))
        {

        }
    }

}
