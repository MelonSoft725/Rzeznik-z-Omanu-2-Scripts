using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class Dialog : MonoBehaviour
{

    public int kto = 0;

    public GameObject rzeznik;
    public GameObject siema;

    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;

    private int index;

    // Start is called before the first frame update
    void Start()
    {
        siema.SetActive(false);
        textComponent.text = string.Empty;
        StartDialogue();
    }

    // Update is called once per frame
    void Update()
    {

        if (index == 1)
        {
            siema.SetActive(true);
            rzeznik.SetActive(false);
        } else if (index == 2)
        {
            siema.SetActive(false);
            rzeznik.SetActive(true);
        } else if (index == 3)
        {
            siema.SetActive(true);
            rzeznik.SetActive(false);
        } else if  (index == 4)
        {
            siema.SetActive(false);
            rzeznik.SetActive(true);
        } else if (index == 5)
        {
            siema.SetActive(true);
            rzeznik.SetActive(false);
        }





        if (Input.GetKeyDown(KeyCode.Space))
        {
            



            if(textComponent.text == lines[index])
            {

                

                NextLine();
            }
            else
            {
                StopAllCoroutines();
                textComponent.text = lines[index];  
            }


        }


    }
    void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }


    void NextLine()
    {

        

        if (index < lines.Length - 1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        } else
        {
            poruszaniesie.CanMove = true;
            gameObject.SetActive(false);
        }
    }

    IEnumerator TypeLine()
    {

        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);

        }

    }
}
