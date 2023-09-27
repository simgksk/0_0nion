using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugSpawn : MonoBehaviour
{
    [SerializeField] GameObject bug_Prefab;
    [SerializeField] Transform bug_Point;

    float delayTime;
    float currentTime;

    void Start()
    {
        
    }

    void Update()
    {
        delayTime = Random.RandomRange(5, 10);
        currentTime += Time.deltaTime;
        
        if (delayTime < currentTime)
        {
            GameObject bug = Instantiate(bug_Prefab, bug_Point.position, Quaternion.identity);
            currentTime = 0;
        }
    }
}
