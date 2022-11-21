using System.Collections;
using System.Collections.Generic;
using GoogleMobileAds.Api;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ReklamManager : MonoBehaviour
{
    public static float timeLeft = 10.0f;
    public string appID = "ca-app-pub-2241979412797784~1916247552";
    public static string interstitialID = "ca-app-pub-3940256099942544/8691691433";

    private static InterstitialAd gecisReklam;
    void Start()
    {
        MobileAds.Initialize(initStatus => { });
        interstitialReklam();
    }
    
    // Update is called once per frame
    void Update()
    {
        gecisReklamGoster();
    }
    public static void interstitialReklam()
    {
        gecisReklam = new InterstitialAd(interstitialID);
        AdRequest yeniReklam = new AdRequest.Builder().Build();
        gecisReklam.LoadAd(yeniReklam);
    }
    public void gecisReklamGoster()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Game") && timeLeft > 0.0f)
        {
            if (gecisReklam.IsLoaded())
            {
                gecisReklam.Show();
            }
            timeLeft -= Time.deltaTime;
        }
        else
        {
            gecisReklam.Destroy();
        }
        Time.timeScale = 1;
    }

}
