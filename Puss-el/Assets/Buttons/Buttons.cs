using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    float speedLeft = 10f;
    float speedRight = -10f;
    float dirX, mySpeed = 4f;
    bool moveRight = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > speedLeft )
        {
            moveRight = false;
        }
        else if (transform.position.x < speedRight )
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
