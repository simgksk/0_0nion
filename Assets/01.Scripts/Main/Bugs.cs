using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Bug
{
    bug_1,
    bug_2
}

public class Bugs : MonoBehaviour
{
    public Bug bug;
    InputManager inputManager;

    Vector2 pos_Bug1;
    RaycastHit2D hit_Bug1;
    Vector2 pos_Bug2;
    RaycastHit2D hit_Bug2;

    private void Awake()
    {
        inputManager = GetComponent<InputManager>();
    }

    private void Start()
    {
        inputManager.onMouseDown += KillBug;
    }

    private void OnDestroy()
    {
        inputManager.onMouseDown -= KillBug;
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        if(bug == Bug.bug_1)
        {
            transform.position += Vector3.right * 1 * Time.deltaTime;

            if (transform.position.x > 10) Destroy(gameObject);
        }
    }

    private void KillBug()
    {
        switch (bug)
        {
            case Bug.bug_1:
                pos_Bug1 = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                hit_Bug1 = Physics2D.Raycast(pos_Bug1, Vector2.zero, 0);

                if (hit_Bug1.collider != null && hit_Bug1.collider.CompareTag("Bug1"))
                {
                    Destroy(gameObject);
                    GameManager.Instance().AddCoin(10);
                    int myResult = GameManager.Instance().GetCoin();
                }
                break;

            case Bug.bug_2:
                pos_Bug2 = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                hit_Bug2 = Physics2D.Raycast(pos_Bug2, Vector2.zero, 0);

                if (hit_Bug2.collider != null && hit_Bug2.collider.CompareTag("Bug2"))
                {
                    Destroy(gameObject);
                    GameManager.Instance().AddCoin(10);
                    int myResult = GameManager.Instance().GetCoin();
                }
                break;
        }
    }
}
