using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCoin : MonoBehaviour
{
    void Start()
    {
        string text = Coin.coin.ToString() + " Coin";
        GetComponent<Text>().text = text;
    }
}
