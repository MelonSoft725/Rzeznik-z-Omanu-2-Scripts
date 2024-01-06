using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace HealthTutorial
{
    public class Character : MonoBehaviour
    {
        [SerializeField] private float _startingHealth = 3;

        static public HealthSystem healthSystem;

        static public int udezenie = 0;

        static public float aaa = HealthSystem.maxHealth;

        [SerializeField] private GameObject ps;

        public Image healthbar;
        static public float healthAmount = aaa;

        

        private void Awake()
        {
            healthSystem = new HealthSystem(_startingHealth);
            healthSystem.PrintHealth();

            healthSystem.OnHealthChanged += OnHealthChanged;
            healthSystem.OnDeath += HandleDeath;
        }

        


        private void HandleDeath()
        {
            Vector3 location = transform.position;
            ps.transform.position = location;
            ps.SetActive(true);


            Destroy(gameObject);
        }

        private void OnHealthChanged()
        {
            healthSystem.PrintHealth();
        }

        public void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.CompareTag("wrog"))
            {


                healthSystem.Health -= 1;

                Character.udezenie = 1;
                StartCoroutine(Cinkciarz());


            }


            if (other.gameObject.CompareTag("EnemyBullet"))
            {

                Destroy(other.gameObject);

                healthSystem.Health -= 1;

                Character.udezenie = 1;

                

                StartCoroutine(Cinkciarz());




            }




        }
    
        IEnumerator Cinkciarz()
        {
            yield return new WaitForSeconds(0.1f);
            Character.udezenie = 0;
            TakeDamage();


        }




        public void TakeDamage()
        {
            healthAmount = healthAmount - 1f;
            
            healthbar.fillAmount = healthSystem.Health / HealthSystem.maxHealth;
            

        }

        public void Heal()
        {
            

            healthbar.fillAmount = healthSystem.Health / HealthSystem.maxHealth;

        }

    }
}
