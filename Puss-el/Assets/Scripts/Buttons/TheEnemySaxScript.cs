using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TheEnemySaxScript : MonoBehaviour
{
    public float enemySpeedLeft = 5f;
    public float enemySpeedRight = -5f;
    float dirX, enemySpeed = 2f;
    bool enemyMoveRight = true;

    

    // Start is called before the first frame update
    void Start()
    {
        //dirX = transform.position.x + 2;
        //enemySpeed = transform.position.x + 2;  
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > enemySpeedLeft)
        {
            enemyMoveRight = false;



        }
        else if (transform.position.x < enemySpeedRight)
        {
            enemyMoveRight = true;
        }
        if (enemyMoveRight == true)
        {
            transform.position = new Vector2(transform.position.x + enemySpeed * Time.deltaTime, transform.position.y);
        }
        else
        {
            transform.position = new Vector2(transform.position.x - enemySpeed * Time.deltaTime, transform.position.y);
        }
    }
    private void OnTriggerEnter2D(Collider2D collison)
    {
        if (collison.gameObject.name == "PlayerTwo")
        {
            SceneManager.LoadScene("Game Over");
        }

        if (collison.gameObject.name == "Teeth")
        {
            SceneManager.LoadScene("Game Over");
        }
    }
}
