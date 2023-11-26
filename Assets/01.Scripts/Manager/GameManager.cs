using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI coinText;
    public int coin = 100;

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
        
    }

    private void Start()
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
    
    public void MinusCoin(int point)
    {
        coin -= point;
        UpdateCoinText();
    }

    public int GetCoin() 
    {
        return coin;
    }
}
