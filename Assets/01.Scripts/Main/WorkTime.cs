using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using Random = UnityEngine.Random;
using TMPro;

public class WorkTime : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI[] timeText;
    [SerializeField] GameObject lockPanel;
    [SerializeField] GameObject FinishWork;
    public GameObject timer;
    [SerializeField] TextMeshProUGUI payText;
    float time = 5;
    int min;
    int sec;
    int rd;

    void Start()
    {
        timer.SetActive(false);
        timeText[0].text = "00";
        timeText[1].text = "00";
    }

    public void Update()
    {
        Timer();
    }

    public void Timer()
    {
        timer.SetActive(true);
        time -= Time.deltaTime;

        min = Mathf.FloorToInt(time / 60);
        sec = Mathf.FloorToInt(time % 60);

        if (min <= 0 && sec <= 0)
        {
            min = 0;
            sec = 0;
        }

        timeText[0].text = min.ToString("D2");
        timeText[1].text = sec.ToString("D2");

        if(time <= 5)
        {
            lockPanel.SetActive(true);
        }
        if(time <= 0)
        {
            lockPanel.SetActive(false);
            timer.SetActive(false);
            rd = Random.Range(1000, 2000);
            payText.text = $": {rd} $";
            FinishWork.SetActive(true);
        }
    }

    public void GetPay()
    {
        FinishWork.SetActive(false);
        GameManager.Instance().AddCoin(rd);
        int myResult = GameManager.Instance().GetCoin();

        timer.SetActive(false);
    }
}
