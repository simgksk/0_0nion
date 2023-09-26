using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bug : MonoBehaviour
{
    float bugSpeed = 1;

    Vector2 pos;
    RaycastHit2D hit;

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
            pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            hit = Physics2D.Raycast(pos, Vector2.zero);

            if (hit.collider != null)
            {
                Destroy(gameObject);
            }
        }
    }
}
