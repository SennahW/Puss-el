using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformUp : MonoBehaviour
{
    float speedLeft = 5f;
    float speedRight = -5f;
    float dirX, mySpeed = 2f;
    bool moveRight = true;

    bool happening = true;

  

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
            if (transform.position.y > speedLeft)
            {
                moveRight = false;



            }
            else if (transform.position.y < speedRight)
            {
                moveRight = true;
            }
            if (moveRight == true)
            {
                transform.position = new Vector2(transform.position.y + mySpeed * Time.deltaTime, transform.position.x);
            }
            else
            {
                transform.position = new Vector2(transform.position.y - mySpeed * Time.deltaTime, transform.position.x);
            }
        }

    }

    
}


