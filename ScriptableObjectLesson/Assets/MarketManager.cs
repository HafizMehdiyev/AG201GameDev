using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MarketManager : MonoBehaviour
{
    public static MarketManager instance;

    public int money;
    public int gem;


    private void OnEnable()
    {
        DontDestroyOnLoad(gameObject);
    }
    private void Awake()
    {
        if (instance == null)
            instance = this;
    }
    private void Start()
    {
        money = PlayerPrefs.GetInt("Money");
    }


    public void MoneyChanged(int SpendMoney)
    {
        money = money - SpendMoney;
        PlayerPrefs.SetInt("Money", money);
        Debug.Log(money);
    }
}
