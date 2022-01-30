using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowCoin : MonoBehaviour
{
    void Start()
    {
        GetComponent<Text>().text = "ÄÚÀÎ : " + Coin.coin;
    }
}
