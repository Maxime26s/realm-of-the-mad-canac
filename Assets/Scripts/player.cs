using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : Entite
{

    public Text textVie;
    bool cd = false;
    public int exp;
    // Start is called before the first frame update
    void Start()
    {
        hp = 100;
        exp = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.tag == "player")
        {
            if (!cd)
            {
                healing();
            }

        }
        if (hp <= 0)
        {
            if (gameObject.tag == "player")
            {
                textVie.text = "Mort";
            }
            Destroy(gameObject);
        }
        switch (exp)
        {
            //niveaux
        }

    }
    public void affichage()
    {
        textVie.text = "Vie : " + hp;
    }

    void healing()
    {
        if (hp < 100)
        {
            hp++;
            textVie.text = "Vie : " + hp;
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
