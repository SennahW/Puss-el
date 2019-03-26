using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttons : MonoBehaviour
{
    float speedLeft = 10f;
    float speedRight = -10f;
    float dirX, myspeed = 4f;
    bool moveright = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > speedLeft )
        {
            moveright = false;

        }
        else if (transform.position.x < speedRight )
        {
            moveright = true;
        }

        if (moveright == true)
        {
            transform.position = new Vector2(transform.position.x + myspeed * Time.deltaTime, transform.position.y);
        }
        else
        {
            transform.position = new Vector2(transform.position.x - myspeed * Time.deltaTime, transform.position.y);
        }
    }
}
