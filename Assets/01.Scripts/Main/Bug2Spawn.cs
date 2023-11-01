using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Bug2Spawn : MonoBehaviour
{
    [SerializeField] GameObject bug2_Prefab;

    float delayTime;
    float currentTime;

    void Start()
    {
        
    }

    void Update()
    {
        delayTime = Random.Range(20,40);
        currentTime += Time.deltaTime;

        if(delayTime < currentTime)
        {
            GameObject bug = Instantiate(bug2_Prefab);
            int rdPos = Random.Range(0, transform.childCount);
            bug.transform.position = transform.GetChild(rdPos).position;

            currentTime = 0;
        }

    }
}
