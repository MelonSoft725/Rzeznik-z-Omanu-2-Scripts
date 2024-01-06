using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossII : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    
    public Transform firingPoint;
    private Rigidbody2D rb;
    private float speed = 0f;
    private float SPEED = 10000f;
    public int licznik = 0;
    public bool CanDash;
    public int liczba = 0;
    public int faza = 1;
    int liczydlo = 0;

    [SerializeField] private GameObject Prefab1;


    

    // Start is called before the first frame update




    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
       
        

        if (faza == 1)
        {
            Spawning();
        }
        else if (faza == 2)
        {
            Atak1();
        }

    }

    // Update is called once per frame
    void Update()
    {
        
        
        

    }

    public void Atak1()
    {
        transform.Rotate(new Vector3(0, 0, 0));
        Instantiate(bullet, firingPoint.position, firingPoint.rotation);
        transform.Rotate(new Vector3(0, 0, 45));
        Instantiate(bullet, firingPoint.position, firingPoint.rotation);
        transform.Rotate(new Vector3(0, 0, 90));
        Instantiate(bullet, firingPoint.position, firingPoint.rotation);
        transform.Rotate(new Vector3(0, 0, 135));
        Instantiate(bullet, firingPoint.position, firingPoint.rotation);
        transform.Rotate(new Vector3(0, 0, 180));
        Instantiate(bullet, firingPoint.position, firingPoint.rotation);
        transform.Rotate(new Vector3(0, 0, 225));
        Instantiate(bullet, firingPoint.position, firingPoint.rotation);
        transform.Rotate(new Vector3(0, 0, 270));
        Instantiate(bullet, firingPoint.position, firingPoint.rotation);
        transform.Rotate(new Vector3(0, 0, 315));
        Instantiate(bullet, firingPoint.position, firingPoint.rotation);

        StartCoroutine(AtakWait());
    }
    IEnumerator AtakWait()
    {
        yield return new WaitForSecondsRealtime(3f);
        faza = 1;
        Start();
    }

    IEnumerator AtakWait2()
    {
        yield return new WaitForSecondsRealtime(3f);
        faza = 2;
        Start();
    }

    public void Spawning()
    {
        for (int i = 0; i < 3; i++)
        {
            Instantiate(Prefab1, firingPoint.position, firingPoint.rotation);
        }

        StartCoroutine(AtakWait2());
    }




    


}
