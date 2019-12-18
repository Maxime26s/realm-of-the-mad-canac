using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject player;

    float moveSpeed = 5f;
    private void Start()
    {
        player = GameObject.FindWithTag("player");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        Vector2 direct = (player.transform.position - gameObject.transform.position).normalized * 0.5f;
        rb.MovePosition(rb.position + direct * moveSpeed * Time.fixedDeltaTime);
    }
}
