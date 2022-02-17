using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
public class ItemList : MonoBehaviour
{
    public static Dictionary<string, int> Items;
    public static Dictionary<string, bool> UseItems;
    public static string GetItems()
    {
        return JsonConvert.SerializeObject(Items);
    }
    public static void SetItems(string json)
    {
        try
        {
            Items = new Dictionary<string, int>(JsonConvert.DeserializeObject<Dictionary<string, int>>(json));
        }
        catch
        {
            Items = new Dictionary<string, int>
            {
                {"", 0}
            };
        }
    }
    public static string GetUesItems()
    {
        return JsonConvert.SerializeObject(UseItems);
    }
    public static void SetUesItems(string json)
    {
        try
        {
            UseItems = new Dictionary<string, bool>(JsonConvert.DeserializeObject<Dictionary<string, bool>>(json));
        }
        catch
        {
            UseItems = new Dictionary<string, bool>
            {
                {"", false}
            };
        }
    }
}
