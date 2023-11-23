using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class WorkTime : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI[] timeText;
    [SerializeField] GameObject lockPanel;
    [SerializeField] GameObject FinishWork;
    public GameObject timer;
    float time = 5;
    int min;
    int sec;

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
            FinishWork.SetActive(true);
        }
    }
}
