using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyItem : MonoBehaviour
{
    public int price = 0;
    public string itemname = "";
    public void Buy()
    {
        Coin.SetCoin(Coin.coin - price);

    }
}
