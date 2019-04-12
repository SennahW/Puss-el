using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    float speedLeft = 5f;
    float speedRight = -5f;
    float dirX, mySpeed = 2f;
    bool moveRight = true;
    
    bool happening = true;

    public GameObject Moves;

    public bool yesItDoesWork;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (happening == true && yesItDoesWork == true)
        {
            if (transform.position.x > speedLeft)
            {
                moveRight = false;



            }
            else if (transform.position.x < speedRight)
            {
                moveRight = true;
            }
            if (moveRight == true)
            {
                transform.position = new Vector2(transform.position.x + mySpeed * Time.deltaTime, transform.position.y);
            }
            else
            {
                transform.position = new Vector2(transform.position.x - mySpeed * Time.deltaTime, transform.position.y);
            }
        }

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        //Debug.Log("Collision Exit");
        if (collision.gameObject.name == "PlayerOne")
        {
            Moves.GetComponent<playerOneMovement>().playerMove = false;
        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {


        //Debug.Log("Collision Enter");
        if (collision.gameObject.name == "PlayerOne")
        {
            Moves.GetComponent<playerOneMovement>().playerMove = true;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "PlayerOne")
        {
            Moves.GetComponent<playerOneMovement>().playerMove = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "PlayerOne")
        {
            Moves.GetComponent<playerOneMovement>().playerMove = false;
        }
    }
}

