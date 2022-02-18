using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyItem : MonoBehaviour
{
    public int price = 0;
    public int addCount = 1;
    public string itemname = "";
    GameObject ShopCoin, Count;
    void Start()
    {
        ShopCoin = GameObject.Find("ShopCoin");
        Count = GameObject.Find(itemname + "Count");
        RenewalCount();
    }
    public void Buy()
    {
        if(Coin.coin - price >= 0)
        {
            Coin.SetCoin(Coin.coin - price);
            ItemList.Items[itemname] += addCount;
            RenewalCoin();
            RenewalCount();
            Debug.Log(itemname + " " + addCount + "�� ��ŭ ���� ���� : " + price);
        }
        else
        {
            Debug.Log("���� ���� ���� ����");
        }
    }
    public void RenewalCoin()
    {
        ShopCoin.GetComponent<Text>().text = Coin.coin.ToString() + " Coin";
    }
    public void RenewalCount()
    {
        Count.GetComponent<Text>().text = ItemList.Items[itemname].ToString();
    }
}
