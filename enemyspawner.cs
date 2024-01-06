using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    [SerializeField] private float spawnRate = 1f;

    [SerializeField] private GameObject[] enemyPrefabs;

    [SerializeField] private bool canSpawn = true;


    

   

    private void Start()
    {

        
        StartCoroutine(Spawner());
        
    }


    private void Update()
    {
        
    }




    private IEnumerator Spawner()
    {
        

        WaitForSeconds wait = new WaitForSeconds(spawnRate);

        
        czarnuch:

        if (wrog1.eee >= 10 && MurBerlinskiTrigger.browar == 1)
        {
            canSpawn = false;
            
            

        }


        if (wrog1.eee <= 10 && MurBerlinskiTrigger.browar == 0)
        {
            canSpawn = true;


        }


        if (canSpawn == false)
        {

            yield return new WaitForSeconds(2);
            goto czarnuch;

        }



        while (canSpawn == true)
        {



            yield return wait;
            int rand = Random.Range(0, enemyPrefabs.Length);
            GameObject enemyToSpawn = enemyPrefabs[rand];

            wrog1.eee = wrog1.eee + 1;





            Instantiate(enemyToSpawn, transform.position, Quaternion.identity);

            if (wrog1.eee >= 10)
            {
                canSpawn = false;
                goto czarnuch;

            }




        }





    }



}
