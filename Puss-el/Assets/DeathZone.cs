using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collison)
    {
        if (collison.gameObject.name == "PlayerTwo")
        {
            SceneManager.LoadScene("Game Over");
        }

        if(collison.gameObject.name == "PlayerOne")
        {
            SceneManager.LoadScene("Game Over");
        }
    }
}
