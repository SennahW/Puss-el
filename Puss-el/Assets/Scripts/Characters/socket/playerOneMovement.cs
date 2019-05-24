using System.Collections;
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
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
        else if (theRB.velocity.x > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
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
            else if (buildIndex == 2)
            {
                PlayerPrefs.SetFloat("LevelTwoCompleted", 1);
            }
            else if (buildIndex == 6)
            {
                PlayerPrefs.SetFloat("LevelThreeCompleted", 1);
            }
            else if (buildIndex == 7)
            {
                PlayerPrefs.SetFloat("LevelFourCompleted", 1);
            }
            else if (buildIndex == 8)
            {
                PlayerPrefs.SetFloat("LevelFiveCompleted", 1);
            }
            else if (buildIndex == 9)
            {
                PlayerPrefs.SetFloat("LevelSixCompleted", 1);
            }
            else if (buildIndex == 10)
            {
                PlayerPrefs.SetFloat("LevelSevenCompleted", 1);
            }
            else if (buildIndex == 11)
            {
                PlayerPrefs.SetFloat("LevelEightCompleted", 1);
            }
            else if (buildIndex == 12)
            {
                PlayerPrefs.SetFloat("LevelNineCompleted", 1);
            }
            else if (buildIndex == 13)
            {
                PlayerPrefs.SetFloat("LevelTenCompleted", 1);
            }
            else if (buildIndex == 14)
            {
                PlayerPrefs.SetFloat("LevelElevenCompleted", 1);
            }
            else if (buildIndex == 15)
            {
                PlayerPrefs.SetFloat("LevelTwelveCompleted", 1);
            }
            else if (buildIndex == 16)
            {
                PlayerPrefs.SetFloat("LevelThirteenCompleted", 1);
            }
            else if (buildIndex == 17)
            {
                PlayerPrefs.SetFloat("LevelFourteenCompleted", 1);
            }
            else if (buildIndex == 18)
            {
                PlayerPrefs.SetFloat("LevelFifteenCompleted", 1);
            }
            else if (buildIndex == 19)
            {
                PlayerPrefs.SetFloat("LevelSixteenCompleted", 1);
            }
            else if (buildIndex == 20)
            {
                PlayerPrefs.SetFloat("LevelSeventeenCompleted", 1);
            }
            else if (buildIndex == 21)
            {
                PlayerPrefs.SetFloat("LevelEighteenCompleted", 1);
            }
            else if (buildIndex == 22)
            {
                PlayerPrefs.SetFloat("LevelNineteenCompleted", 1);
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
