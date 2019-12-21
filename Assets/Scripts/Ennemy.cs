using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ennemy : Entite
{
    GameObject player;
    public TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        text = transform.GetChild(0).GetComponentInChildren<TextMeshProUGUI>();
        player = GameObject.FindWithTag("player");
        float distance = Mathf.Sqrt(Mathf.Pow(player.transform.position.x, 2) + Mathf.Pow(player.transform.position.y, 2));
        if (distance < 105)
        {
            distance = 3;
        }
        else if (distance < 170)
        {
            distance = 2;
        }
        else if(distance < 290)
        {
            distance = 1.5f;
        }
        else if(distance < 340)
        {
            distance = 1.25f;
        }
        else
        {
            distance = 1;
        }
        hp = (int)(100*distance);
        text.text = "Vie : " + hp;
    }

    // Update is called once per frame
    void Update()
    {
        if (hp <= 0)
        {
            GameObject.FindGameObjectWithTag("player").GetComponent<player>().exp +=20;
            Destroy(gameObject);           
        }
    }

    public void affichageEnnemy()
    {
        text.text = "Vie : " + hp;
    }
}
