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
        Decrease();
    }

    private void Decrease()
    {
        StartCoroutine(DecreaseRoutine());
    }

    IEnumerator DecreaseRoutine()
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
        StartCoroutine(IncreaseRoutine());
    }

    IEnumerator IncreaseRoutine()
    {
        while (true)
        {
            water.SetFloat("water", -1);
            water.Play("Water_Shrink");

            yield return new WaitForSeconds(stopAnimTime);

            Decrease();
        }
    }
}