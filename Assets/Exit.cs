using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;
using System.IO;
using System;

public class Exit : MonoBehaviour
{
    private void Start()
    {
        DontDestroyOnLoad(gameObject);
        transform.Find("ExitCanvas").gameObject.SetActive(false);
        LoadGame();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0f;
            transform.Find("ExitCanvas").gameObject.SetActive(true);
        }
    }
    public void ExitYes()
    {
        Application.Quit();
    }
    public void ExitNo()
    {
        Time.timeScale = 1f;
        transform.Find("ExitCanvas").gameObject.SetActive(false);
    }
    public void LoadGame()
    {
        try
        {
            Score.bestScore = PlayerPrefs.GetInt("BestScore");
            Coin.coin = PlayerPrefs.GetInt("Coin");
            ItemList.SetItems(PlayerPrefs.GetString("Items"));
            ItemList.SetUesItems(PlayerPrefs.GetString("UseItems"));
            Debug.Log("불러오기 성공");
        }
        catch { }
    }
    public void SaveGame()
    {
        try
        {
            PlayerPrefs.SetInt("BestScore", Score.bestScore);
            PlayerPrefs.SetInt("Coin", Coin.coin);
            PlayerPrefs.SetString("Items", ItemList.GetItems());
            PlayerPrefs.SetString("UseItems", ItemList.GetUesItems());
            Debug.Log("저장 성공");
        }
        catch
        {
            ItemList.SetItems("");
            ItemList.SetUesItems("");
        }
    }
    private void OnApplicationQuit()
    {
        SaveGame();
    }
}
