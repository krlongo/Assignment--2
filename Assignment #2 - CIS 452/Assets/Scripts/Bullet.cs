/*
 * Kevon Long
 * Bullet.cs
 * Assignment #2
 * Behavior for the bullets that shoot at the player, killing them if it hits
 * */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    float moveSpeed = 7f;

    Rigidbody2D rb;

    Player target;
    Vector2 moveDirection;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindObjectOfType<Player>();
        moveDirection = (target.transform.position - transform.position).normalized * moveSpeed;
        rb.velocity = new Vector2(moveDirection.x, moveDirection.y);
        Destroy(gameObject, 3f);
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.name.Equals("Player"))
        {
            Destroy(gameObject);
            Destroy(collider.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
