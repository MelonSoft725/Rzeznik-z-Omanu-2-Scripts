using HealthTutorial;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PotkiScript : MonoBehaviour
{
    [SerializeField] Image healthbar;
    public TextMeshProUGUI text;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void Heal()
    {
        ;

        healthbar.fillAmount = HealthSystem.health / HealthSystem.maxHealth;

    }

    // Update is called once per frame
    void Update()
    {


        text.text = "" + ShopManager.potki;

        if (Input.GetKeyDown(KeyCode.E))
        {

            if (ShopManager.potki > 0)
            {
                ShopManager.potki = ShopManager.potki - 1;


                if (HealthSystem.health < HealthSystem.maxHealth)
                {
                    HealthSystem.health++;
                }

                

                Heal();

            }



        }


    }
}
