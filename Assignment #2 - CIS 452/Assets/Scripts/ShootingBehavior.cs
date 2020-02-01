/*
 * Kevon Long
 * ShootingBehavior.cs
 * Assignment #2
 * This shows how long the player has been alive in the game
 * */

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullet : IShootingBehavior
{
    public void Shoot()
    {
        Debug.Log("shot bullet");
    }
}
public class ShootLazer: IShootingBehavior
{
    public void Shoot()
    {
        Debug.Log("shot lazer");
    }
}

