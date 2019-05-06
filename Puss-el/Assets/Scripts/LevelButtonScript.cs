using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelButtonScript : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            PlayerPrefs.DeleteAll();
        }
    }
    public void  LevelOne()
    {
        SceneManager.LoadScene(1);
    }
    public void LevelTwo()
    {
        if (PlayerPrefs.GetFloat("LevelOneCompleted", 0) == 1)
        {
            SceneManager.LoadScene(2);
        }
    }
    public void LevelThree()
    {
        if (PlayerPrefs.GetFloat("LevelTwoCompleted", 0) == 1)
        {
            SceneManager.LoadScene(3);
        }
    }
    public void LevelFour()
    {
        if (PlayerPrefs.GetFloat("LevelThreeCompleted", 0) == 1)
        {
            SceneManager.LoadScene(4);
        }
    }
    public void LevelFive()
    {
        if (PlayerPrefs.GetFloat("LevelFourCompleted", 0) == 1)
        {
            SceneManager.LoadScene(5);
        }
    }
    public void LevelSix()
    {
        if (PlayerPrefs.GetFloat("LevelFiveCompleted", 0) == 1)
        {
            SceneManager.LoadScene(6);
        }
    }
}

