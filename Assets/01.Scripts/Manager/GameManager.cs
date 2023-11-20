using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager = null;

    [SerializeField] TextMeshProUGUI coinText;
    int coin = 100;

    private void Awake()
    {
        if(gameManager == null)
        {
            gameManager = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            if (gameManager != this)
            {
                Destroy(gameObject);
            }
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

}
