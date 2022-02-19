using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    private int currentLevel;
    private void Start()
    {
        currentLevel = PlayerPrefs.GetInt("currentLevel");
        Debug.Log(currentLevel);
    }
    // if win 
    public void NextLevel()
    {
        if(currentLevel != 0)
            SceneManager.LoadScene(currentLevel);
        else
            SceneManager.LoadScene(1);

        if(currentLevel >= SceneManager.sceneCountInBuildSettings-1)
            SceneManager.LoadScene(1);
        else
        {
            currentLevel += 1;
            PlayerPrefs.SetInt("currentLevel",currentLevel);
        }

    }

}
