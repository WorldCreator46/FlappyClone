using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
public class ItemList : MonoBehaviour
{
    public static Dictionary<string, int> Items = new Dictionary<string, int>() {};
    public static Dictionary<string, bool> UseItems = new Dictionary<string, bool>() { };
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
            Debug.Log("오류");
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
            Debug.Log("오류");
        }
    }
}
