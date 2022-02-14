using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public static int coin;
    public new SpriteRenderer renderer;
    private void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
    }
    public static void SetCoin(int value)
    {
        if (value >= 0)
        {
            coin = value;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GetComponent<AudioSource>().Play();
        coin++;
        renderer.enabled = false;
    }
}
