using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkinManager : MonoBehaviour
{
    public DBSkins dataSkin;
    [SerializeField] private GameObject activeSkin;
    [SerializeField] private GameObject setsButton;
    [SerializeField] private GameObject buysButton;
    [SerializeField] private GameObject impostorMain;
    [SerializeField] private Text pricetext;
    [SerializeField] private Text mainPrice;
    


    private int coins = 0;
    private int index = 0;

    private void Awake()
    {
        for (int i = 0; i < dataSkin.scins.Length; i++)
        {
            if (PlayerPrefs.GetInt($"Skin{i}") == 1)
            {
                dataSkin.scins[i]._isBought = true;
            }
        }
    }
    private void Start()
    {
        index = PlayerPrefs.GetInt("activSkin");
        coins = PlayerPrefs.GetInt("money");
        mainPrice.text = $"{coins}";
        SaveElements();
        //impostorMain.GetComponent<Image>().sprite = dataSkin.scins[index]._skin;
    }
    public void SaveElements()
    {
        activeSkin.GetComponent<Image>().sprite = dataSkin.scins[index]._skin;
        if (dataSkin.scins[index]._isBought == false)
        {
            buysButton.SetActive(true);
            pricetext.text = dataSkin.scins[index]._priceSkin.ToString();
        }
        else
        {
            buysButton.SetActive(false);
        }
        if (index != PlayerPrefs.GetInt("activSkin"))
        {
            setsButton.SetActive(true);
        }
        else
        {
            setsButton.SetActive(false);
        }

    }
    public void pressRight()
    {
        if (dataSkin.GetLenghts() == index + 1)
        {
            index = 0;
        }
        else
        {
            index += 1;
        }
        SaveElements();
    }
    public void pressLeft()
    {
        if (index == 0)
        {
            index = dataSkin.GetLenghts() - 1;
        }
        else
        {
            index -= 1;
        }
        SaveElements();
    }
    public void SelectSkin()
    {
        setsButton.SetActive(false);
        PlayerPrefs.SetInt("activSkin", index);
        //impostorMain.GetComponent<Image>().sprite = dataSkin.scins[index]._skin;
    }
    public void BuySkin()
    {
        if (dataSkin.scins[index]._priceSkin <= coins)
        {
            dataSkin.scins[index]._isBought = true;
            coins -= dataSkin.scins[index]._priceSkin;
            PlayerPrefs.SetInt("money", coins);
            mainPrice.text = coins.ToString();
            SaveElements();
            PlayerPrefs.SetInt($"Skin{index}", 1);
        }
    }

}

