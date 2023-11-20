using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveDust : MonoBehaviour
{
    Rigidbody2D rigid;

    private void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Click();
    }

    private void Click()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rigid.gravityScale = 1;
            Destroy(gameObject, 2);
        }

    }
}
