using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopCoin : MonoBehaviour
{
    void Start()
    {
        SetCoin();
    }
    public void SetCoin()
    {
        string text = Coin.coin.ToString() + " Coin";
        GetComponent<Text>().text = text;
    }
}
