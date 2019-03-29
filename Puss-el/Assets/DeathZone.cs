using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathZone : MonoBehaviour
{
    private int nextSceneToLoad;

    private void Start()
    {
        nextSceneToLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }

    private void OnTriggerEnter2D(Collider2D collison)
    {
        if (collison.gameObject.name == "PlayerTwo")
        {
            SceneManager.LoadScene(nextSceneToLoad);
        }

        if(collison.gameObject.name == "PlayerOne")
        {
            SceneManager.LoadScene(nextSceneToLoad);
        }
    }
}
