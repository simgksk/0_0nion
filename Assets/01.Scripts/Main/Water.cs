using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using DG.Tweening;

public class Water : MonoBehaviour
{
    Animator water;

    float playAnimTime = .02f;
    float stopAnimTime = 10;

    void Start()
    {
        water = GetComponent<Animator>();
    }

    void Update()
    {
        StartCoroutine(Decrease());
        
    }

    IEnumerator Decrease()
    {
        while (true)
        {
           /* water.Play("Water_Shrink", (int)playAnimTime);
            yield return new WaitForSeconds(playAnimTime);
            water.StopPlayback();
            yield return new WaitForSeconds(stopAnimTime);
            water.Play("Water_Shrink");
            yield return new WaitForSeconds(playAnimTime);*/
        }

        yield return null;
    }
}
