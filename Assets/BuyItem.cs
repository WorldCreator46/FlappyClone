using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyItem : MonoBehaviour
{
    public int price = 0;
    public int count = 0;
    public string itemname = "";
    public void Buy()
    {
        Coin.SetCoin(Coin.coin - price);
        if (ItemList.Items.TryGetValue(itemname, out count))
        {
            ItemList.Items[itemname] = count + 1;
        }
        else
        {
            ItemList.Items.Add(itemname, 1);
        }
    }
}
