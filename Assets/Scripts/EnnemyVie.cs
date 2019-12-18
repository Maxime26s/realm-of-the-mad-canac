using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyVie : MonoBehaviour
{
    int vie;
    // Start is called before the first frame update
    void Start()
    {
         vie= 100;
    }

    // Update is called once per frame
    void Update()
    {
        if (vie <=0)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        vie = vie - 20;
    }
}
