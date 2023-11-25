using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using DG.Tweening;

public class Water : MonoBehaviour
{
    [SerializeField] GameObject[] waters;

    int currentWater = 0;

    private void Start()
    {
        StartCoroutine(DecreaseWater());
    }

    IEnumerator DecreaseWater()
    {
        while (true)
        {
            for(int i=0; i<waters.Length; i++)
            {
                waters[i].SetActive(false);
                yield return new WaitForSeconds(1);

            }
        }
    }
}