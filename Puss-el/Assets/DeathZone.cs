using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D trig)
    {
        if (trig.gameObject.name == "Player")
        {
            SceneManager.LoadScene("Game Over");
        }
    }
}
