using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using DG.Tweening;

public class Water : MonoBehaviour
{
    [SerializeField] GameObject[] waters;
    [SerializeField] GameObject needWater_TextBox;

    int currentWater = 0;

    Coroutine decreaseCoroutine;
    Coroutine increaseCoroutine;
    
    private void Start()
    {
        decreaseCoroutine = StartCoroutine(DecreaseWaterRoutine());
    }

    IEnumerator DecreaseWaterRoutine()
    {
        while (true)
        {
            for(int i=0; i<waters.Length-1; i++)
            {
                //Debug.Log(currentWater);
                currentWater += 1;
                waters[i].SetActive(false);

                if (currentWater > 20) needWater_TextBox.SetActive(true);
                else if (currentWater <= 20) needWater_TextBox.SetActive(false); 

                yield return new WaitForSeconds(5);
            }
        }
    }

    public void IncreaseWater()
    {
        if (decreaseCoroutine != null)
        {
            StopCoroutine(decreaseCoroutine);
            decreaseCoroutine = null;
            GameManager.Instance().AddGood(50);
            int myResult1 = GameManager.Instance().GetGood();
        }

        if (increaseCoroutine == null)
            increaseCoroutine = StartCoroutine(IncreaseWaterRoutine());
    }

    IEnumerator IncreaseWaterRoutine()
    {
        int startIncrease = Mathf.Max(0, currentWater - 5); 

        while (currentWater > startIncrease)
        {
            for (int i = waters.Length - 1; i >= startIncrease; i--)
            {
                if (i < waters.Length)
                {
                    currentWater -= 1;
                    //Debug.Log(currentWater);
                    waters[i].SetActive(true);

                    yield return new WaitForSeconds(1);
                }
            }
        }

        if (waters.Length == 0)
        {
            decreaseCoroutine = StartCoroutine(DecreaseWaterRoutine());
        }
        else decreaseCoroutine = StartCoroutine(DecreaseWaterRoutine());

        increaseCoroutine = null;
    }
}