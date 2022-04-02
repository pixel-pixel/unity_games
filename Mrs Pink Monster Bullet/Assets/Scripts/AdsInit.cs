using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdsInit : MonoBehaviour, IUnityAdsInitializationListener
{
    [SerializeField] private string androidGameId;
    [SerializeField] private string iOSGameId;
    [SerializeField] private bool testMode;
    void Awake()
    {
        var gameId = (Application.platform == RuntimePlatform.IPhonePlayer) ? iOSGameId : androidGameId;
        Advertisement.Initialize(gameId, false, this);
    }

    public void OnInitializationComplete()
    {
        Debug.Log("Ads init completed");
    }

    public void OnInitializationFailed(UnityAdsInitializationError error, string message)
    {
        Debug.Log("Ads init failed");
    }
}
