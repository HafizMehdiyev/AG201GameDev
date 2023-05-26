using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public MarketNonSingletone marketnonsingletone;

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    private void OnEnable()
    {
        DontDestroyOnLoad(gameObject);  
    }
    public void Buy()
    {
        MarketManager.instance.MoneyChanged(5);
        marketnonsingletone.SpendMoney();
    }
}
