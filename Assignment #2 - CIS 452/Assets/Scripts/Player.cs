/*
 * Kevon Long
 * Player.cs
 * Assignment #2
 * Lets you control the players movements and color movements. It also kills the player if the colors were incorrect
 * */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour, IChangeColor
{
    public Color currentColor;
    public int currentColorIndex;

    float dirX, dirY;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
        currentColorIndex = 0;
        GetComponent<SpriteRenderer>().color = Color.red; //starts as Red
        currentColor = Color.red;
    }

    public void ChangeColor()
    {
        if (currentColor == Color.red)
        {
            GetComponent<SpriteRenderer>().color = Color.blue;
            currentColor = Color.blue;
            Debug.Log("changed to blue");
            Debug.Log(currentColor);
        }
        else if (currentColor == Color.blue) 
        {
            GetComponent<SpriteRenderer>().color = Color.yellow;
            currentColor = Color.yellow;
            Debug.Log(currentColor);
        }
        else if (currentColor == Color.yellow) 
        {
            GetComponent<SpriteRenderer>().color = Color.red;
            currentColor = Color.red;
            Debug.Log(currentColor);
        }

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            ChangeColor();
        }

        dirX = Input.GetAxis("Horizontal") * 10f;
        dirY = Input.GetAxis("Vertical") * 10f;

    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(dirX, dirY);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(!(collision.gameObject.GetComponent<SpriteRenderer>().color == currentColor))
        {
            Destroy(gameObject);
            SceneManager.LoadScene("LoseScreen");
        }
    }
}

