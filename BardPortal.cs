using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BardPortal : MonoBehaviour
{

    public GameObject scenka;
    public GameObject muzyka;

    int zmienna = 0;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            scenka.SetActive(true);
            muzyka.SetActive(false);
            zmienna = 1;
            
            StartCoroutine(licznig());
            
        }
        
    }

    private void Update()
    {
        if (zmienna == 1)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadSceneAsync(2);
            

            }
        }
    }


    IEnumerator licznig()
    {
        yield return new WaitForSecondsRealtime(21f);
        zmienna = 0;
        SceneManager.LoadSceneAsync(2);
    }

}
