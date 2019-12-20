using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject balle;
    public float vitesseBalle = 10f;
    bool cd = false;

    // Update is called once per frame
    void Update()
    {
        if (!cd && Input.GetMouseButton(0))
        {
                Shoot();
                StartCoroutine(shot());            
        }
    }

    void Shoot()
    {
        GameObject balle1 = Instantiate(balle, firePoint.position, firePoint.rotation, transform);
        Destroy(balle1,1f);
        Rigidbody2D rb = balle1.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * vitesseBalle, ForceMode2D.Impulse);
    }
    IEnumerator shot()
    {
        cd = true;
        yield return new WaitForSeconds(0.25f);
        cd = false;
    }
}
