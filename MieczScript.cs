using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MieczScript : MonoBehaviour
{

    public UnityEvent OnAttackPeformed;

    static public int damage = 1;

    

    

    private void OnCollisionEnter2D(Collision2D other)
    {
        
        if (other.gameObject.CompareTag("wrog"))
        {
            if (Input.GetMouseButton(0))
            {



            }
        }

        

    }


    public void TriggerAttack()
    {
        OnAttackPeformed?.Invoke();
    }
    

}
