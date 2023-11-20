using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class DirtySpawner : MonoBehaviour
{
    [SerializeField] GameObject soilPrefab;
    [SerializeField] GameObject dustPrefab;

    void Start()
    {
        Spawn(1);
        Spawn(2);
        Spawn(3);
        Spawn(4);
        Spawn(5);
    }

    private void Spawn(int index)
    {
        GameObject soil = Instantiate(soilPrefab);
        GameObject dust = Instantiate(dustPrefab);
        int rd = Random.Range(0, transform.childCount);
        soil.transform.position = transform.GetChild(rd).position;
        dust.transform.position = transform.GetChild(rd).position;
    }

}
