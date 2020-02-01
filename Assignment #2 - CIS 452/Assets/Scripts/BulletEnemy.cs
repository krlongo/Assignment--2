/*
 * Kevon Long
 * BulletEnemy.cs
 * Assignment #2
 * Shoots a bullet at the player
 * */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemy : Enemy
{
    public GameObject bullet;

    public float firerate;
    float nextFire;
    float moveSpeed = 7f;

    public Rigidbody2D rb;

    public Player target;
    public Vector2 moveDirection;

    public void Start()
    {
        firerate = 1f;
        nextFire = Time.time;
        ShootingBehavior = new ShootBullet();
    }

    public override void Die()
    {
        Destroy(gameObject);
    }

    private void Update()
    {
        DoShoot();
        if(Time.time > nextFire)
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
            nextFire = Time.time + firerate;
        }
    }

}
