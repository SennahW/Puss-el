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
            SceneManager.LoadScene(6);
        }
    }
    public void LevelFour()
    {
        if (PlayerPrefs.GetFloat("LevelThreeCompleted", 0) == 1)
        {
            SceneManager.LoadScene(7);
        }
    }
    public void LevelFive()
    {
        if (PlayerPrefs.GetFloat("LevelFourCompleted", 0) == 1)
        {
            SceneManager.LoadScene(8);
        }
    }
    public void LevelSix()
    {
        if (PlayerPrefs.GetFloat("LevelFiveCompleted", 0) == 1)
        {
            SceneManager.LoadScene(9);
        }
    }
    public void LevelSeven()
    {
        if (PlayerPrefs.GetFloat("LevelSixCompleted", 0) == 1)
        {
            SceneManager.LoadScene(10);
        }
    }
    public void LevelEight()
    {
        if (PlayerPrefs.GetFloat("LevelSevenCompleted", 0) == 1)
        {
            SceneManager.LoadScene(11);
        }
    }
    public void LevelNine()
    {
        if (PlayerPrefs.GetFloat("LevelEightCompleted", 0) == 1)
        {
            SceneManager.LoadScene(12);
        }
    }
    public void LevelTen()
    {
        if (PlayerPrefs.GetFloat("LevelNineCompleted", 0) == 1)
        {
            SceneManager.LoadScene(13);
        }
    }
    public void LevelEleven()
    {
        if (PlayerPrefs.GetFloat("LevelTenCompleted", 0) == 1)
        {
            SceneManager.LoadScene(14);
        }
    }
    public void LevelTwelve()
    {
        if (PlayerPrefs.GetFloat("LevelElevenCompleted", 0) == 1)
        {
            SceneManager.LoadScene(15);
        }
    }
    public void LevelThirteen()
    {
        if (PlayerPrefs.GetFloat("LevelTwelveCompleted", 0) == 1)
        {
            SceneManager.LoadScene(16);
        }
    }
    public void LevelFourteen()
    {
        if (PlayerPrefs.GetFloat("LevelThirteenCompleted", 0) == 1)
        {
            SceneManager.LoadScene(17);
        }
    }
    public void LevelFifteen()
    {
        if (PlayerPrefs.GetFloat("LevelFourteenCompleted", 0) == 1)
        {
            SceneManager.LoadScene(18);
        }
    }
    public void LevelSixteen()
    {
        if (PlayerPrefs.GetFloat("LevelFifteenCompleted", 0) == 1)
        {
            SceneManager.LoadScene(19);
        }
    }
    public void LevelSeventeen()
    {
        if (PlayerPrefs.GetFloat("LevelSixteenCompleted", 0) == 1)
        {
            SceneManager.LoadScene(20);
        }
    }
    public void LevelEighteen()
    {
        if (PlayerPrefs.GetFloat("LevelSeventeenCompleted", 0) == 1)
        {
            SceneManager.LoadScene(21);
        }
    }
    public void LevelNineteen()
    {
        if (PlayerPrefs.GetFloat("LevelEighteenCompleted", 0) == 1)
        {
            SceneManager.LoadScene(22);
        }
    }
    public void LevelTweeny()
    {
        if (PlayerPrefs.GetFloat("LevelNineteenCompleted", 0) == 1)
        {
            SceneManager.LoadScene(23);
        }
    }
}

