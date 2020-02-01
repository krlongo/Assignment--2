/*
 * Kevon Long
 * Timer.cs
 * Assignment #2
 * This shows how long the player has been alive in the game
 * */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timer;
    public float time;

    // Start is called before the first frame update
    void Start()
    {
        time = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        timer.text = "Time: " + time;
    }
}
