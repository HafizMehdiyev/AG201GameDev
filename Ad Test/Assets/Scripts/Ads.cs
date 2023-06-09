using GoogleMobileAds.Api;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ads : MonoBehaviour
{
    public GameObject Button;
    public int Score = 0;
    public string rewardedAdId = "ca-app-pub-3940256099942544/6300978111";
    private RewardedAd rewardedAd;

    public string bannerId = "ca-app-pub-3940256099942544/5224354917";
    private BannerView bannerView;
    void Start()
    {
        MobileAds.Initialize((InitializationStatus initStatus) =>
        {
        });
        Score = PlayerPrefs.GetInt("Score");
        LoadRewardedAd();
        RequestBanner();
    }

    void RequestBanner()
    {
        bannerView = new BannerView(bannerId, AdSize.Banner, AdPosition.BottomRight);
        AdRequest request = new AdRequest.Builder().Build();
        bannerView.LoadAd(request);
    }
    public void LoadRewardedAd()
    {
        // Clean up the old ad before loading a new one.
        if (rewardedAd != null)
        {
            rewardedAd.Destroy();
            rewardedAd = null;
        }
        Debug.Log("Yeni rewarded ad yuklendi");


        // create our request used to load the ad.
        var adRequest = new AdRequest.Builder().Build();

        // send the request to load the ad.
        RewardedAd.Load(rewardedAdId, adRequest,
            (RewardedAd ad, LoadAdError error) =>
            {
                // if error is not null, the load request failed.
                if (error != null || ad == null)
                {
                    Debug.LogError("Rewarded ad failed to load an ad " +
                                   "with error : " + error);
                    return;
                }

                Debug.Log("Rewarded ad loaded with response : "
                          + ad.GetResponseInfo());

                rewardedAd = ad;
            });
    }
    public void ShowBanner()
    {
        RequestBanner();
    }
    public void ShowRewardedAd()
    {
        const string rewardMsg =
            "Rewarded ad rewarded the user. Type: {0}, amount: {1}.";

        if (rewardedAd != null && rewardedAd.CanShowAd())
        {
            rewardedAd.Show((Reward reward) =>
            {
                // TODO: Reward the user.
                Score += 155;
                Debug.Log(Score);
                PlayerPrefs.SetInt("Score",Score);
                Button.SetActive(false);
                Debug.Log(String.Format(rewardMsg, reward.Type, reward.Amount));
            });
        }
    }
}
