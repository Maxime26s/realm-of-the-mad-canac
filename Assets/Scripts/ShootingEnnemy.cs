using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingEnnemy : MonoBehaviour
{
    public Transform firePoint;
    public GameObject balle;
    public float vitesseBalle = 2f;
    bool cd = false;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("player");
    }

    // Update is called once per frame
    void Update()
    {
        if (!cd)
        {
            Shoot();
            StartCoroutine(shot());
        }
    }

    void Shoot()
    {
        GameObject balle1 = Instantiate(balle, firePoint.position, firePoint.rotation, transform);
        Destroy(balle1, 1f);
        Rigidbody2D rb = balle1.GetComponent<Rigidbody2D>();
        Vector3 lookDirect = new Vector3(player.transform.position.x - gameObject.transform.position.x, player.transform.position.y - gameObject.transform.position.y).normalized;
        rb.AddForce(lookDirect * vitesseBalle, ForceMode2D.Impulse);
    }
    IEnumerator shot()
    {
        cd = true;
        yield return new WaitForSeconds(0.75f);
        cd = false;
    }
}
