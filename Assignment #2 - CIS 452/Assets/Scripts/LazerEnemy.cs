/*
 * Kevon Long
 * LazerEnemy.cs
 * Assignment #2
 * Shoots a lazer at the player
 * */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerEnemy : Enemy
{
    public GameObject bullet;

    public float firerate;
    float nextFire;
    float moveSpeed = 7f;

    public Rigidbody2D rb;

    public Player target;
    public Vector2 moveDirection;

    public void Awake()
    {
        firerate = 1f;
        nextFire = Time.deltaTime;
        ShootingBehavior = new ShootLazer();
    }

    public override void Die()
    {
        Destroy(gameObject);
    }

    private void Update()
    {
        DoShoot();
        if (Time.deltaTime > nextFire)
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
            nextFire = Time.deltaTime + firerate;
        }
    }
}
