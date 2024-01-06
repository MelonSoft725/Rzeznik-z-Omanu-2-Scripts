using HealthTutorial;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGuzior : MonoBehaviour
{
    public void Menu()
    {

        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        Application.Quit();

    }


    public void Restart()
    {

        BossAdin.Max_BossHealth2 = 200f;
        BossAdin.BossHealth2 = BossAdin.Max_BossHealth2;

        BossAdin.boss2Dead = 0;
        RedScript.secret = 0;
        //ShopManager instance;

        //ShopManager.potki = 0;
        //ShopManager.karabin = 0;
        TriggerE.e = 0;
        poruszaniesie.CanMove = true;

        //ShopManager.gumak = 0;
        //BlokSkrypt.kedzior = 0;
        //KaczkaScript.kaczka = 0;
        //KedziorTrigger.c = 0;
        RedScript.foss = 0;
        NexeScript.Nexe = 0;
        Zuz.zuzia = 0;

        KatanaTrigger.katana = 0;

        KosccScript.damage = 1;
        Rocket.Damage = 8;
        MieczScript.damage = 2;
        TornadoScript.damage = 6;
        skryptdlapudelkawoku.Maxbron = 1;
        HealthSystem.health = 4;
        HealthSystem.maxHealth = 4;
        //KluczPickUp.klucz = 0;
        //bramapiekiel.BossStart = 0;
        //wrog1.eee = 0;
        Character.udezenie = 0;
        //Character.aaa = HealthSystem.maxHealth;
        //Character.healthAmount = Character.aaa;
        //MurBerlinskiTrigger.browar = 0;
        scoreScript.gold = 0;
        skryptdlapudelkawoku.fireRate = 0.5f;
        pocisk2.damage = 1;
        KluczPickUp.trafienie = 0;
        NapisyToDo.kupiony_item = 0;
        pocisk.damage = 1;

        poruszaniesie.dashCounter = 0;
        poruszaniesie.dashCoolCounter = 0;
        BossPocisk1Script.damage = 1;

        BossHP.Max_BossHealth = 200;
        BossHP.BossHealth = BossHP.Max_BossHealth;
        BossHP.cooldown = 4f;
        //BossHP.boss_dead = 0;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


}
