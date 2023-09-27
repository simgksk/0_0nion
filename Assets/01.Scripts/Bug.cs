using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Bug : MonoBehaviour
{
    float bugSpeed = 1;

    Vector2 bug_Pos;
    RaycastHit2D bug_Hit;

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
            bug_Pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            bug_Hit = Physics2D.Raycast(bug_Pos, Vector2.zero);

            if (bug_Hit.collider != null)
            {
                Destroy(gameObject);
            }
        }
    }
}
