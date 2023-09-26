using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Onion : MonoBehaviour
{
    [SerializeField] GameObject onion_Information;

    Vector2 pos;
    RaycastHit2D hit;

    void Start()
    {
        onion_Information.SetActive(false);
    }

    void Update()
    {
        Informaition_On();
    }

    private void Informaition_On()
    {
        if (Input.GetMouseButtonDown(0))
        {
            pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            hit = Physics2D.Raycast(pos, Vector2.zero);

            if(hit.collider != null)
            {
                onion_Information.SetActive(true);
            }
        }
    }
}
