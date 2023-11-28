using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using System;

public class GameManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI coinText;
    public int coin = 100;

    [SerializeField] TextMeshProUGUI goodText;
    public int good = 0;
    public int maxGood = 999;

    [SerializeField] GameObject[] onions;
    [SerializeField] GameObject[] texts;

    AudioSource levelUp;

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

        levelUp = GetComponent<AudioSource>();
    }

    private void Start()
    {
        for (int i = 0; i < texts.Length; i++)
        {
            if (texts[i] == null)
            {
                Debug.LogError($"Texts array element at index {i} is not assigned in the Inspector!");
            }
        }

        UpdateCoinText();
        UpdateGoodText();
        onions[0].SetActive(true);
    }

    private void UpdateGoodText()
    {
        goodText.text = good+"%";
    }

    private void UpdateCoinText()
    {
        coinText.text = coin+"$";
    }

    public void AddCoin(int point)
    {
        coin += point;
        UpdateCoinText();
    }
    
    public void AddGood(int point)
    {
        good += point;
        ChageOnion();
        UpdateGoodText();
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
    
    public int GetGood() 
    {
        return good;
    }

    public void ChageOnion()
    {
        
        if(good >= 333)
        {
            levelUp.Play();

            onions[0].SetActive(false);
            onions[1].SetActive(true);
            onions[2].SetActive(false);
            onions[3].SetActive(false);


            texts[0].SetActive(false);
            texts[1].SetActive(true);
            texts[2].SetActive(false);
            texts[3].SetActive(false);
        }
        
        if(good >= 666)
        {
            levelUp.Play();
            onions[0].SetActive(false);
            onions[1].SetActive(false);
            onions[2].SetActive(true);
            onions[3].SetActive(false);

            texts[0].SetActive(false);
            texts[1].SetActive(false);
            texts[2].SetActive(true);
            texts[3].SetActive(false);
        }
        
        if(good >= 999)
        {
            levelUp.Play();
            onions[0].SetActive(false);
            onions[1].SetActive(false);
            onions[2].SetActive(false);
            onions[3].SetActive(true);

            texts[0].SetActive(false);
            texts[1].SetActive(false);
            texts[2].SetActive(false);
            texts[3].SetActive(true);
        }
        
        if(good >= 1111)
        {
            SceneManager.LoadScene(3);
        }
    }
}
