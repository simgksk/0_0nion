using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public enum Spawner
{
    Spawn_Bug1,
    Spawn_Bug2
}

public class BugsSpawn : MonoBehaviour
{
    public Spawner spawner;

    [SerializeField] GameObject bug1_Prefab;
    [SerializeField] GameObject bug2_Prefab;

    [SerializeField] Transform bug1_Pos;

    float delayTime;
    float currentTime;

    void Update()
    {
        Spawn();
    }

    private void Spawn()
    {
        switch (spawner)
        {
            case Spawner.Spawn_Bug1:
                delayTime = Random.Range (10, 30);
                currentTime += Time.deltaTime;

                if (delayTime < currentTime)
                {
                    GameObject bug1 = Instantiate(bug1_Prefab, transform);
                    bug1.transform.position = bug1_Pos.position;
                    currentTime = 0;
                }
                break;

            case Spawner.Spawn_Bug2:
                delayTime = Random.Range(20, 40);
                currentTime += Time.deltaTime;

                if (delayTime < currentTime)
                {
                    GameObject bug2 = Instantiate(bug2_Prefab, transform);
                    int rdPos = Random.Range(0, transform.childCount);
                    bug2.transform.position = transform.GetChild(rdPos).position;

                    currentTime = 0;
                }
                break;
        }
    }
}
