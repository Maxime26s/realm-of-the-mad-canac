using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entite : MonoBehaviour
{
    protected int hp;
    // Update is called once per frame
    void Update()
    {
        
    }
    public void perteDeVie()
    {
        hp -= 20;
    }
}
