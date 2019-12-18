using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemySpawn : MonoBehaviour
{
    public GameObject ennemy;
    bool cd = false;
    GameObject player;
    int [] tab = { -10, 10 };
    void Start()
    {
        player = GameObject.FindWithTag("player");
    }
    // Update is called once per frame
    void Update()
    {
        if (!cd)
        {
            
            Vector2 position = new Vector2(player.transform.position.x + 10* Mathf.Cos(Random.Range(0f,2 * Mathf.PI)), player.transform.position.y + 10* Mathf.Sin(Random.Range(0f, 2 * Mathf.PI)));
            Instantiate(ennemy,position,Quaternion.identity);
            StartCoroutine(spawns());
        }
        
    }

    IEnumerator spawns()
    {
        cd = true;
        yield return new WaitForSeconds(3f);
        cd = false;
    }
}
