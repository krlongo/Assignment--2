/*
 * Kevon Long
 * Enemy.cs
 * Assignment #2
 * abstract class that gives all of the enemies their behaviors
 * */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{

    public IShootingBehavior ShootingBehavior { get; set; }

    public virtual void DoShoot() { ShootingBehavior.Shoot(); }

    public abstract void Die();

    //public abstract void PerformShot();

    // Update is called once per frame
    void Update()
    {
        
    }
}
