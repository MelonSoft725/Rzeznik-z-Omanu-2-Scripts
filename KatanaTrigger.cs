using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KatanaTrigger : MonoBehaviour
{
    public GameObject item;

    int b = 0;
    static public int katana = 0;

    private void Update()
    {

        if (katana == 1 && b == 0)
        {
            b = 1;
            StartCoroutine(Time());

        }





    }


    public IEnumerator Time()
    {

        katana = 1;
        skryptdlapudelkawoku.Maxbron++;
        item.SetActive(true);
        yield return new WaitForSecondsRealtime(3f);

       

        // item.SetActive(false);
        // yield return new WaitForSecondsRealtime(1f);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(Time());
            Destroy(gameObject);
        }


    }

}
