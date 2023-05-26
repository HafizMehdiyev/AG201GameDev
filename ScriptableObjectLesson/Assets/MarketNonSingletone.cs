using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarketNonSingletone : MonoBehaviour
{
    public int money= 10;

    public void SpendMoney()
    {
        money -= 5;
    }
}
