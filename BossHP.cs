using HealthTutorial;
using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHP : MonoBehaviour
{
    static public float obrot;

    public Transform target;
    public Transform firingPoint;

    public float speed = 20f;
    public float rotateSpeed = 1f;
    private Rigidbody2D rb;

    [SerializeField] GameObject pocisk1;

    [SerializeField] private GameObject ps;
    [SerializeField] private GameObject ps1;
    [SerializeField] private GameObject rakietyPrefab;
    [SerializeField] private GameObject rakietyPrefab2;

    


    public static float Max_BossHealth = 100;

    public static float BossHealth = Max_BossHealth;

    public Image Bosshealthbar;

    static public float cooldown = 4f;

    public int faza = 0;

    int licznik_skokow = 0;

    public int licznik = 0;

    int licznik_faz = 0;

    static public int boss_dead = 0;

    public int rakiety = 0;

    // Start is called before the first frame update
    void Start()
    {
        // ps.SetActive(false);

        Fade();


    }


    void AtakPociskami()
    {

        

        StartCoroutine(AtakPociskami2());

    }

    IEnumerator AtakPociskami2()
    {


        for (float a = 83f; a >= 0; a -= 1f)
        {

            Instantiate(pocisk1, firingPoint.position, firingPoint.rotation);

            yield return new WaitForSecondsRealtime(0.1f);

            licznik++;

        }












    }

    // Update is called once per frame
    void Update()
    {

        


        Vector3 location = transform.position;
        ps1.transform.position = location;


        if (licznik_faz == 0)
        {



            if (faza == 0)
            {
                licznik_faz = 1;
                DashWait2();
            }
            else if (faza == 1)
            {
                licznik_faz = 1;
                AtakPociskami();
            }
            else
            {

            }

        } else
        {

        }


        if (rakiety == 0 && BossHealth <= Max_BossHealth * 0.5 )
        {

            Rakiety();


        }



        if (licznik == 84)
        {
            licznik = 0;
            faza = 0;
            licznik_faz = 0;
            transform.rotation = Quaternion.identity;


        }


        // rb.velocity = transform.up * speed;


        if (BossHealth <= 0)
        {

            boss_dead = 1;

            Destroy(gameObject);

            
        }



    }


    void Rakiety()
    {
        StartCoroutine(Rakiety2());
    }


    IEnumerator Rakiety2()
    {

        rakiety = 1;



        Instantiate(rakietyPrefab);
        Instantiate(rakietyPrefab2);

        yield return new WaitForSecondsRealtime(10f);


        rakiety = 0;
    }



    void Dash()
    {

        




        

        


        


    }

    void DashWait2()
    {
        Dash();
        transform.rotation = Quaternion.identity;


        StartCoroutine(DashWait());


    }


    IEnumerator DashWait()
    {
        


        if (BossHP.cooldown == 0f)
        {





            transform.position = target.position;


            
            ps.SetActive(true);

        }



        for (float f = 5f; f >= 0; f -= 1f )
        {

            BossHP.cooldown = f;

            transform.rotation = Quaternion.identity;



            if (BossHP.cooldown == 3f)
            {
                if (GameObject.FindGameObjectWithTag("Player"))
                {

                    target = GameObject.FindGameObjectWithTag("kropka").transform;

                }
            }



            if (BossHP.cooldown > 0f)
            {
               // ps.SetActive(false);
                yield return new WaitForSecondsRealtime(0.3f);


            }
            else
            {
                yield return new WaitForSecondsRealtime(0.01f);


                licznik_skokow++;

                if (licznik_skokow == 6)
                {

                    faza = 1;
                    licznik_faz = 0;
                    licznik_skokow = 0;

                }
                else
                {
                    StartCoroutine(DashWait());
                }



                


            }



        }
    }


    void Fade()
    {
        StartCoroutine("FadeInn");
    }


    IEnumerator FadeInn()
    {
        for (float f = 0.05f; f <= 1; f += 0.05f)
        {
            f += 0.05f;
            Bosshealthbar.fillAmount = f;
            yield return new WaitForSeconds(0.1f);
        }

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("bullet"))
        {

            

            Destroy(other.gameObject);


           

            


            BossTakeDamage();



        }



    }

    public void BossTakeDamage()
    {
        BossHealth = BossHealth - 1f;

        Bosshealthbar.fillAmount = BossHealth / Max_BossHealth;




    }




}
