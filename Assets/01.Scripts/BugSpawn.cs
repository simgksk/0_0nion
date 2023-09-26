using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugSpawn : MonoBehaviour
{
    [SerializeField] GameObject bug_Prefab;
    [SerializeField] Transform bug_Point;

    void Start()
    {
        
    }

    void Update()
    {
        GameObject bug = Instantiate(bug_Prefab, bug_Point.position, Quaternion.identity);
    }
}
