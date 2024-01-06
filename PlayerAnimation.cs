using HealthTutorial;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] private Animator animator;

    [SerializeField] private Animator animator2;
    void Update()
    {
        if (Character.udezenie == 0)
        {
            animator.SetBool("boli", false);


        }
        else if (Character.udezenie == 1)
        {

            animator.SetBool("boli", true);
        }

       



    }
}
