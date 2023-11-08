using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using DG.Tweening;

public class Water : MonoBehaviour
{
    Animator water;
    

    float playAnimTime = .1f;
    float stopAnimTime = 3;

    bool isPlayingAnim = false;

    void Start()
    {
        water = GetComponent<Animator>();

        isPlayingAnim = water;
        StartCoroutine(Decrease());
    }

    void Update()
    {
        
    }

    IEnumerator Decrease()
    {
        while (true)
        {
            water.Play("Water_Shrink");
            isPlayingAnim = true;
            yield return new WaitForSeconds(playAnimTime);

            water.speed = 0;
            isPlayingAnim = false;
            yield return new WaitForSeconds(stopAnimTime);

            water.speed = 1;
            isPlayingAnim = true;
            yield return new WaitForSeconds(playAnimTime);
        }

    }

    public void Increase()
    {
        water.speed = -1;
    }
}
