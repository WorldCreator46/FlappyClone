using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelControll : MonoBehaviour
{
    string[] panels = { "1" };
    void Start()
    {
        foreach (string temp in panels)
        {
            GameObject.Find("Panel").transform.Find(temp).gameObject.SetActive(false);
        }
        GameObject.Find("Panel").transform.Find("1").gameObject.SetActive(true);
    }
    public void back()
    {
        foreach (string temp in panels)
        {
            if (GameObject.Find("Panel").transform.Find(temp).gameObject.activeSelf)
            {
                int t = int.Parse(temp);
                if (t <= 1)
                {
                    t = panels.Length;
                }
                else
                {
                    t--;
                }
                GameObject.Find("Panel").transform.Find(temp).gameObject.SetActive(false);
                GameObject.Find("Panel").transform.Find(t.ToString()).gameObject.SetActive(true);
                GameObject.Find("Page").GetComponent<Text>().text = temp;
                break;
            }
        }
    }
    public void next()
    {
        foreach (string temp in panels)
        {
            if (GameObject.Find("Panel").transform.Find(temp).gameObject.activeSelf)
            {
                int t = int.Parse(temp);
                if (t >= panels.Length)
                {
                    t = 1;
                }
                else
                {
                    t++;
                }
                GameObject.Find("Panel").transform.Find(temp).gameObject.SetActive(false);
                GameObject.Find("Panel").transform.Find(t.ToString()).gameObject.SetActive(true);
                GameObject.Find("Page").GetComponent<Text>().text = temp;
                break;
            }
        }
    }
}
