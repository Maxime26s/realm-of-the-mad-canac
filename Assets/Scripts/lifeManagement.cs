using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lifeManagement : MonoBehaviour
{
    int vie;
    public Text textVie;
    bool cd = false;
    // Start is called before the first frame update
    void Start()
    {
         vie= 100;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.tag == "player")
        {
            if (!cd)
            {
             healing();
            } 
            
        }
        if (vie <=0)
            {
                if (gameObject.tag == "player")
                {
                textVie.text = "Mort";
                }
                Destroy(gameObject);
            }
        
    }

    public void perteDeVie()
    {
        vie = vie - 20;
    }

    public void affichage()
    {
        textVie.text = "Vie : " + vie;
    }

    void healing()
    {
        if(vie < 100)
        {
            vie++;
            textVie.text = "Vie : " + vie;
            StartCoroutine(cooldown());
        }   
    }
    IEnumerator cooldown()
    {
        cd = true;
        yield return new WaitForSeconds(1f);
        cd = false;
    }
}
