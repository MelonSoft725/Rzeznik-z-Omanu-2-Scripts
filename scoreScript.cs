using HealthTutorial;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class scoreScript : MonoBehaviour
{
    public Text MylifeText;
    public Text MyscoreText;
    static public int gold;


    void Start()
    {

        gold = 0;
        MyscoreText.text = "x" + gold;
        MylifeText.text = "  " + HealthSystem.health;
    }

    private void Update()
    {
        MyscoreText.text = "x" + scoreScript.gold;
        MylifeText.text = HealthSystem.health + "/" + HealthSystem.maxHealth;
        ;
    }
}
