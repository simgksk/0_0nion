using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bug2 : MonoBehaviour
{
    InputManager input;

    Vector3 bug_Pos;
    RaycastHit2D bug_Hit;

    int point = 10;

    private void Awake()
    {
        input = GetComponent<InputManager>();
    }

    void Start()
    {
        input.onMouseDown += BugDie;
    }

    private void OnDestroy()
    {
        input.onMouseDown -= BugDie;
    }

    private void BugDie()
    {
        bug_Pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        bug_Hit = Physics2D.Raycast(bug_Pos, Vector2.zero, 0);

        if (bug_Hit.collider != null && bug_Hit.collider.CompareTag("Bug2"))
        {
            Destroy(gameObject);
            GameManager.gameManager.AddCoin(point);
        }
    }

}
