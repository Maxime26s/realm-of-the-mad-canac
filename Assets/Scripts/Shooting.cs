using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject balle;
    public float vitesseBalle = 10f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject balle1 = Instantiate(balle, firePoint.position, firePoint.rotation);
        Destroy(balle1,1f);
        Rigidbody2D rb = balle1.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * vitesseBalle, ForceMode2D.Impulse);
    }
}
