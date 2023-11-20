using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SoilSpawner : MonoBehaviour
{
    [SerializeField] GameObject soilPrefab;

    void Start()
    {
        Spawn1();
        Spawn2();
        Spawn3();
    }

    private void Spawn1()
    {
        GameObject soil1 = Instantiate(soilPrefab);
        int rd1 = Random.Range(0, transform.childCount);
        soil1.transform.position = transform.GetChild(rd1).position;
    }
    
    private void Spawn2()
    {
        GameObject soil2 = Instantiate(soilPrefab);
        int rd2 = Random.Range(0, transform.childCount);
        soil2.transform.position = transform.GetChild(rd2).position;
    }
    
    private void Spawn3()
    {
        GameObject soil3 = Instantiate(soilPrefab);
        int rd3 = Random.Range(0, transform.childCount);
        soil3.transform.position = transform.GetChild(rd3).position;
    }
}
