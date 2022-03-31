using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SwitchScene : MonoBehaviour
{
    private int currentLevel;
    public DBLevels levels;
    public AdsCore controllerADS;
    public GameObject WinUI;
    public GameObject LoseUI;
    private int currentMoney;
    private int counterWinLevel;

    [SerializeField] private Text textCurrentMoney;
    [SerializeField] private Text textMoneyFrimWin;
    [SerializeField] private Text textCurrentMoneyLoseIcon;// text money in Lose UI

    private void Start()
    {
        currentLevel = PlayerPrefs.GetInt("currentLevel");
        Debug.Log(currentLevel);
        currentMoney = PlayerPrefs.GetInt("money");
        counterWinLevel = PlayerPrefs.GetInt("counterWinLevel");
        counterWinLevel += 1;
        PlayerPrefs.SetInt("counterWinLevel", counterWinLevel);
    }
    private int myRandMoney = 0;//if you win, gets money 
    public void GetWinUI()
    {
        Debug.Log(counterWinLevel);
        Debug.Log(counterWinLevel%2);
        if (counterWinLevel % 2 == 0)
            controllerADS.ShowSkipVideo();

        myRandMoney = Random.Range(25, 100);
        textMoneyFrimWin.text = $"+{myRandMoney}";
        textCurrentMoney.text = $"{currentMoney + myRandMoney}";
        myRandMoney += currentMoney; // for new current money
        PlayerPrefs.SetInt("money", myRandMoney);
        WinUI.SetActive(true); 
    }
    public void GetLoseUI()
    {
        if (counterWinLevel % 2 == 0)
            controllerADS.ShowSkipVideo();

        textCurrentMoneyLoseIcon.text = $"{currentMoney}"; 
        LoseUI.SetActive(true); 
    }
    public void NextLevel()
    {
        if(currentLevel == 0)
        {
            currentLevel += 1;
            PlayerPrefs.SetInt("currentLevel", currentLevel);
            SceneManager.LoadScene(1);
        }
        else if (currentLevel >= SceneManager.sceneCountInBuildSettings-1)
        {
            currentLevel = 1;
            PlayerPrefs.SetInt("currentLevel", currentLevel);
            SceneManager.LoadScene(1);
        }
        else
        {
            currentLevel += 1;
            PlayerPrefs.SetInt("currentLevel", currentLevel);
            SceneManager.LoadScene(currentLevel);
        }
    }

    public void Restart()
    {
        controllerADS.ShowFullVideo();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void ExitToMenu()
    {
        controllerADS.ShowFullVideo();
        SceneManager.LoadScene(0);
    }
    private bool enableUpdate = true;// if win or lose = 1 times Update
    private void Update()
    {
        if (enableUpdate)
        {
            var current = levels.CurrentLevel();
            if (current.isFinished)
            {
                if (current.win)
                {
                    GetWinUI();
                    enableUpdate = false;
                }
                else
                {
                    GetLoseUI();
                    enableUpdate = false;
                }
            }
        }
    }
}
