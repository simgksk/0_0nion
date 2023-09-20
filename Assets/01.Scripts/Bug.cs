using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bug : MonoBehaviour
{
    float bugSpeed = 1;

    void Start()
    {
        
    }

    void Update()
    {
        Move();
        BugDie();
    }

    private void Move()
    {
        transform.position += Vector3.right * bugSpeed * Time.deltaTime;
    }

    private void BugDie()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Destroy(gameObject);
        }
    }
}
