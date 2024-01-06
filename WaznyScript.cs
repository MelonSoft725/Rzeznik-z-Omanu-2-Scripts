using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaznyScript : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject music;

    void Start()
    {
        StartCoroutine(waiter_not_that_waiter_just_waiter());
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(gameObject);
            music.SetActive(true);

        }          

    }

    IEnumerator waiter_not_that_waiter_just_waiter()
    {
        yield return new WaitForSeconds(57f);
        //my code here after 3 seconds
        music.SetActive(true);
        Destroy(gameObject);


    }

}
