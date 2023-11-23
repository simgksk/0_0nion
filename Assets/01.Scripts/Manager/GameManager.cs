using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI coinText;
    int coin = 100;
    public int currentCoin = 0;

    // Singleton pattern
    static GameManager _instance = null;
    public static GameManager Instance() { return _instance; }

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
        /*else
        {
            if (this != _instance)
                Destroy(gameObject);
        }*/
    }

    private void Start()
    {
        currentCoin = coin;
        InitializeGameState();
    }

    private void InitializeGameState()
    {
        UpdateCoinText();
    }

    private void UpdateCoinText()
    {
        coinText.text = "" + coin;
    }

    public void AddCoin(int point)
    {
        coin += point;
        UpdateCoinText();
    }

    public int GetCoin() 
    {
        return coin;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        UpdateCoinText();
    }

    private void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}
