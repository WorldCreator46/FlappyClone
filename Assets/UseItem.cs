using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UseItem : MonoBehaviour
{
    public string itemname = "";
    GameObject Count, Panel, State;
    void Start()
    {
        Count = GameObject.Find(itemname + "Count");
        Count.GetComponent<Text>().text = ItemList.Items[itemname].ToString();
        Panel = GameObject.Find(itemname);
        State = GameObject.Find(itemname + "State");
        Check();
    }
    public void Check()
    {
        if (ItemList.UseItems[itemname])
        {
            Use();
        }
        else
        {
            Clear();
        }
    }
    public void Click()
    {
        if(!ItemList.UseItems[itemname])
        {
            Use();
        }
        else
        {
            Clear();
        }
    }
    public void Use()
    {
        ItemList.UseItems[itemname] = true;
        Panel.GetComponent<Image>().color = Color.red;
        State.GetComponent<Text>().text = "해제";
    }
    public void Clear()
    {
        ItemList.UseItems[itemname] = false;
        Panel.GetComponent<Image>().color = Color.white;
        State.GetComponent<Text>().text = "사용";
    }
}
