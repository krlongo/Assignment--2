/*
 * Kevon Long
 * ShrinkingCircles.cs
 * Assignment #2
 * Shrinks the enemy circles and picks the color it is from random when it's created
 * */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrinkingCircles : MonoBehaviour, IChangeColor
{

    public Color[] colors = { Color.red, Color.blue, Color.yellow };
    public Color shrinkingColor;

    // Start is called before the first frame update
    void Awake()
    {
        ChangeColor();
    }
    

    // Update is called once per frame
    void Update()
    {
       transform.localScale -= new Vector3(.01f, .01f, 0.0f);

        if (transform.localScale.x < 0 && transform.localScale.y < 0)
        {
            Destroy(gameObject);
        }
    }

    public void ChangeColor()
    {
        shrinkingColor = colors[Random.Range(0, 3)];
        GetComponent<SpriteRenderer>().color = shrinkingColor;
    }
}
