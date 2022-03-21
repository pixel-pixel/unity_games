using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    [SerializeField] private GameObject iconShop;
    [SerializeField] private GameObject closeIconShop;
    [SerializeField] private GameObject shopUI;
    private int currentLevel; //last 
    public void openShop()
    {
        shopUI.SetActive(true);
        iconShop.SetActive(false);
        closeIconShop.SetActive(true);
    }
    public void closeShop()
    {
        shopUI.SetActive(false);
        closeIconShop.SetActive(false);
        iconShop.SetActive(true);
    }
    public void BtnStart()
    {
        currentLevel = PlayerPrefs.GetInt("currentLevel");// get last Scene play
        if(currentLevel == 0)
        {
            currentLevel += 1;
            PlayerPrefs.SetInt("currentLevel", currentLevel);
        }
        SceneManager.LoadScene(currentLevel);
    }
}
