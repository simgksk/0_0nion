using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;

public class DirtySpawner : MonoBehaviour
{
    [SerializeField] GameObject soilPrefab;
    [SerializeField] GameObject dustPrefab;
    [SerializeField] GameObject clearPanel;

    List<Transform> spawnPos = new List<Transform>();
    List<GameObject> spawnPrefabs = new List<GameObject>();

    private void Start()
    {
        clearPanel.SetActive(false);
    }

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

        RemoveAllWhenReady();
    }

    private bool AllPrefabsDestroyed()
    {
        return spawnPrefabs.All(prefab => prefab == null);
    }

    private void RemoveAllWhenReady()
    {
        StartCoroutine(RemoveAllCoroutine());
    }

    private IEnumerator RemoveAllCoroutine()
    {
        yield return new WaitUntil(() => AllPrefabsDestroyed());

        yield return new WaitForSeconds(.5f);
        clearPanel.SetActive(true);

        GameManager.Instance().AddCoin(100);
        int myResult = GameManager.Instance().GetCoin();
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
