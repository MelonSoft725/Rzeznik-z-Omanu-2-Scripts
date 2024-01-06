using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossAdin : MonoBehaviour
{

    [SerializeField] private GameObject Boss;
    [SerializeField] private GameObject Boss1;
    [SerializeField] private GameObject klapa;

    public static float Max_BossHealth2 = 200f;

    public static float BossHealth2 = Max_BossHealth2;

    public Image Bosshealthbar2;

    public bool heal = false;

    static public int boss2Dead = 0;

    IEnumerator FadeInn()
    {
        for (float f = 0.05f; f <= 1; f += 0.05f)
        {
            f += 0.05f;
            Bosshealthbar2.fillAmount = f;
            yield return new WaitForSeconds(0.1f);
        }
        heal = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("FadeInn");
    }

    private void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.CompareTag("bullet"))
        {
            Destroy(other.gameObject);
            BossTakeDamage();
        }

        if (other.gameObject.CompareTag("tornado"))
        {
            Destroy(other.gameObject);
            BossTakeDamage1();
        }

    }

    private void Update()
    {
        if (heal)
        {
            Bosshealthbar2.fillAmount = BossAdin.BossHealth2 / BossAdin.Max_BossHealth2;
        }

        if (BossHealth2 <= 0)
        {
            boss2Dead = 1;
            klapa.SetActive(true);
            Destroy(Boss);
            Destroy(Boss1);
        }




        if (BossAdin.BossHealth2 > BossAdin.Max_BossHealth2)
        {
            BossAdin.BossHealth2 = BossAdin.Max_BossHealth2;
        }

    }

    public void BossTakeDamage1()
    {
        BossHealth2 = BossHealth2 - TornadoScript.damage;

        Bosshealthbar2.fillAmount = BossHealth2 / Max_BossHealth2;




    }

    public void BossTakeDamage()
    {
        BossHealth2 = BossHealth2 - 1f;

        Bosshealthbar2.fillAmount = BossHealth2 / Max_BossHealth2;




    }
}
