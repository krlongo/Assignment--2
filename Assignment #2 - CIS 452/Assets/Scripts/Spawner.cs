/*
 * Kevon Long
 * Spawner.cs
 * Assignment #2
 * spawns the circles
 * */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject shrinkingCircle;

    public float timer;

    public void Start()
    {
        //enemiesToSpawn.Add(new BulletEnemy());
        //enemiesToSpawn.Add(new LazerEnemy());

        Instantiate(shrinkingCircle);
    }

    public void Update()
    {
        timer += Time.deltaTime;
        if(timer >= 3.0f)
        {
            timer = 0f;
            Instantiate(shrinkingCircle, new Vector3(0.0f, 0.0f, 0.0f), new Quaternion());
        }
    }
}
