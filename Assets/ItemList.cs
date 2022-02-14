using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
public class ItemList : MonoBehaviour
{
    public static Dictionary<string, int> Items = new Dictionary<string, int>() {};
    public static string GetDict()
    {
        return JsonConvert.SerializeObject(Items);
    }
    public static void SetDict(string json)
    {
        try
        {
            Items = new Dictionary<string, int>(JsonConvert.DeserializeObject<Dictionary<string, int>>(json));
        }
        catch
        {
            Debug.Log("¿À·ù");
        }
    }
}
