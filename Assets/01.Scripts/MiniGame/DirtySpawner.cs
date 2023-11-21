using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class DirtySpawner : MonoBehaviour
{
    [SerializeField] GameObject soilPrefab;
    [SerializeField] GameObject dustPrefab;

    List<Transform> spawnPos = new List<Transform>();
    List<GameObject> spawnPrefabs = new List<GameObject>();

    public void Spawner()
    {
        foreach (Transform child in transform)
        {
            spawnPos.Add(child);
        }

        for (int i = 0; i < 7; i++)
        {
            Spawn_Dust(i);
            Spawn_Soil(i);
        }

        RemoveAll();
    }

    private void RemoveAll()
    {
        bool allPrefabsRemoved = true;

        foreach (GameObject allPrefabs in spawnPrefabs)
        {
            if (allPrefabs != null)
            {
                allPrefabsRemoved = false;
                break;
            }
        }

        if (allPrefabsRemoved)
        {
            Debug.Log("All prefabs have been removed");
        }
        else
        {
            Debug.Log("Not all prefabs have been removed");
        }
    }

    private void Spawn_Soil(int index)
    {
        GameObject soil = Instantiate(soilPrefab);
        int rd = Random.Range(0, spawnPos.Count);
        Transform spawnPoint = spawnPos[rd];
        soil.transform.position = spawnPoint.position;

        spawnPos.RemoveAt(rd);
        spawnPrefabs.Add(soil);
    }
    
    private void Spawn_Dust(int index)
    {
        GameObject dust = Instantiate(dustPrefab);
        int rd = Random.Range(0, spawnPos.Count);
        Transform spawnPoint = spawnPos[rd];
        dust.transform.position = spawnPoint.position;

        spawnPos.RemoveAt(rd);
        spawnPrefabs.Add(dust);
    }

}
