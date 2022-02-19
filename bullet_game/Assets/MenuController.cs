using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    [SerializeField] private GameObject iconShop;
    [SerializeField] private GameObject closeIconShop;
    [SerializeField] private GameObject shopUI;

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
}
