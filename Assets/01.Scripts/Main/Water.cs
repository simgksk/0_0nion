using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using DG.Tweening;

public class Water : MonoBehaviour
{
    Animator water;

    float delayTime = 5;
    float amount = 1;
    float startTime;
    bool isAnimating = false;

    void Start()
    {
        water = GetComponent<Animator>();
    }

    void Update()
    {
        Decrease();
        
    }

    private void Decrease()
    {
        if (!isAnimating)
        {
            if(Time.time >= startTime + delayTime)
            {
                water.SetFloat("ShrinkAmount", amount);
                water.SetTrigger("ShrinkWater");
                isAnimating = true;
            }
        }
    }
}
