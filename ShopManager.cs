using HealthTutorial;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class ShopManager : MonoBehaviour
{
    static public ShopManager instance;


    public Upgrade[] upgrades;


    public GameObject SklepikUI;
    public Transform shopContent;
    public GameObject itemPrefab;
    public poruszaniesie player;

    [SerializeField] GameObject karabinek;
    [SerializeField] GameObject gumak2;


    static public int gumak = 0;
    [SerializeField] Image healthbar;

    static public int karabin = 0;


    int ilosc = 0;

    static public int potki = 0;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        } else
        {
          // Destroy(gameObject);
        }
    
        //DontDestroyOnLoad(gameObject);
    
    
    }

    private void Start()
    {
        foreach (Upgrade upgrade in upgrades)
        {
            GameObject item = Instantiate(itemPrefab, shopContent);

            upgrade.itemRef = item;

            

            foreach (Transform child in item.transform)
            {
                if (child.gameObject.name == "poziom")
                {
                    child.gameObject.GetComponent<Text>().text = "Kupionych " + upgrade.quantity.ToString();
                } else if (child.gameObject.name == "koszt")
                {
                    child.gameObject.GetComponent<Text>().text = "Koszt " + upgrade.cost.ToString();

                } else if (child.gameObject.name == "nazwaitema")
                {
                    child.gameObject.GetComponent<Text>().text = upgrade.name.ToString();
                } else if (child.gameObject.name == "Image")
                {
                    child.gameObject.GetComponent<Image>().sprite = upgrade.image;
                }
            }

            item.GetComponent<Button>().onClick.AddListener(() =>
            {
                BuyUpgrade(upgrade);
            });




        }
    }

    

    public void BuyUpgrade (Upgrade upgrade)
    {
       



        if (scoreScript.gold >= upgrade.cost)
        {
            scoreScript.gold -= upgrade.cost;
            upgrade.quantity++;
            
            upgrade.itemRef.transform.GetChild(0).GetComponent<Text>().text = "kupionych " + upgrade.quantity.ToString();


            
            
            
            
            ApplyUpgrade(upgrade);

        }
   
        

    
    
    
    }

    public void ApplyUpgrade(Upgrade upgrade)
    {
        switch(upgrade.name)
        {
            case "Karabin AK-47":


                karabin = 1;
                NapisyToDo.kupiony_item = 1;
                skryptdlapudelkawoku.Maxbron++;
                upgrade.itemRef.transform.GetChild(0).GetComponent<Text>().text = "MAX ";
                karabinek.SetActive(true);

                break;
            default:
                Debug.Log("No upgrade Available");
                break;

            case "Wiecej Zycia":
                HealthSystem.maxHealth += 1;
                HealthSystem.health += 1;
                NapisyToDo.kupiony_item = 1;
                Heal2();
                break;

            case "Mikstura Lecznicza":

                potki++;
                NapisyToDo.kupiony_item = 1;
                Heal();

                break;

            case "Gu Mac-Zestaw":

                pocisk.damage++;
                NapisyToDo.kupiony_item = 1;
                gumak = 1;
                upgrade.itemRef.transform.GetChild(0).GetComponent<Text>().text = "MAX ";
                gumak2.SetActive(true);
                break;

        }
    }

    public void Heal()
    {
        ;

        healthbar.fillAmount = HealthSystem.health / HealthSystem.maxHealth;

    }


    public void Heal2()
    {
        ;

        healthbar.fillAmount = HealthSystem.health / HealthSystem.maxHealth;

    }


    public void ToggleShop()
    {
        SklepikUI.SetActive(!SklepikUI.activeSelf);
        
    }

    private void OnGUI()
    {
        
    }
}

[System.Serializable]
public class Upgrade
{
    public string name;
    public  int cost;
    public Sprite image;
    [HideInInspector] public int quantity;
    [HideInInspector] public GameObject itemRef;


}
