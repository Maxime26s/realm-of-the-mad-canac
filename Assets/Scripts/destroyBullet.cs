using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyBullet : MonoBehaviour
{
    string ignore;

    private void Awake()
    {
        ignore = transform.parent.gameObject.tag;
        transform.parent = null;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag != ignore)
        {
            if(collision.tag == "Ennemy")
            {
                collision.gameObject.GetComponent<Entite>().perteDeVie();
                Destroy(gameObject);
            }
            else if(collision.tag == "player")
            {
                collision.gameObject.GetComponent<Entite>().perteDeVie();
                collision.gameObject.GetComponent<player>().affichage();
                Destroy(gameObject);
            }
            
        }
    }
}
