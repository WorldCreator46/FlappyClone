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
            ItemList.SetDict(PlayerPrefs.GetString("Items"));
            Debug.Log("불러오기 성공");
        }
        catch
        {
            Score.bestScore = 0;
            Coin.coin = 0;
        }
    }
    public void SaveGame()
    {
        try
        {
            PlayerPrefs.SetInt("BestScore", Score.bestScore);
            PlayerPrefs.SetInt("Coin", Coin.coin);
            PlayerPrefs.SetString("Items", ItemList.GetDict());
            Debug.Log(Score.bestScore+"\n"+ Coin.coin+"\n"+ ItemList.GetDict());
            Debug.Log("저장 성공");
        }
        catch
        {
            PlayerPrefs.SetInt("BestScore", 0);
            PlayerPrefs.SetInt("Coin", 0);
        }
    }
    private void OnApplicationQuit()
    {
        SaveGame();
    }
}
