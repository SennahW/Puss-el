﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerOneMovement : MonoBehaviour
{
    private int nextSceneToLoad;
    public float moveSpeed;
    public float jumpForce;

    public bool playerMove = false;
    private int itGoesFast = 10;

    public KeyCode left;
    public KeyCode right;
    public KeyCode jump;

    private Rigidbody2D theRB;

    public Transform groundCheckPoint;
    public float groundCheckRadius;
    public LayerMask whatIsGround;

    public bool isGrounded;

    public int buildIndex;

    private void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        buildIndex = currentScene.buildIndex;
        theRB = GetComponent<Rigidbody2D>();
        nextSceneToLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }

    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheckPoint.position, groundCheckRadius, whatIsGround);
        if(Input.GetKey(left))
        {
            theRB.velocity = new Vector2(-moveSpeed, theRB.velocity.y);
        }
        else if (Input.GetKey(right))
        {
            theRB.velocity = new Vector2(moveSpeed, theRB.velocity.y);
        }
        else
        {
            theRB.velocity = new Vector2(0, theRB.velocity.y);
        }

        if(Input.GetKeyDown(jump) && isGrounded)
        {
            theRB.velocity = new Vector2(theRB.velocity.x, jumpForce);
        }
        if (theRB.velocity.x < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else if (theRB.velocity.x > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
    }

    private void OnTriggerEnter2D(Collider2D collison)
    {
        if (collison.gameObject.tag == "PlayerTwo")
        {
            if (buildIndex == 1)
            {
                PlayerPrefs.SetFloat("LevelOneCompleted", 1);
            }
            if (buildIndex == 2)
            {
                PlayerPrefs.SetFloat("LevelTwoCompleted", 1);
            }
            SceneManager.LoadScene(5);        
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag.Equals("Moving platform"))
        {
            this.transform.parent = col.transform;
        }
    }

    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Moving platform"))
        {
            this.transform.parent = null;
        }
    }

}