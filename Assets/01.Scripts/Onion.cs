using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Onion : MonoBehaviour
{
    [SerializeField] GameObject onion_Information;

    Vector2 onion_Pos;
    RaycastHit2D Onion_Hit;

    bool isInformation;

    void Start()
    {
        onion_Information.SetActive(false);
        isInformation = onion_Information;
    }

    void Update()
    {
        OnOff_Information();
    }

    private void OnOff_Information()
    {
        if (Input.GetMouseButtonDown(0))
        {
            onion_Pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Onion_Hit = Physics2D.Raycast(onion_Pos, Vector2.zero);

            if(Onion_Hit.collider != null)
            {
                onion_Information.SetActive(true);
            }
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            if(isInformation == false)
            {
                onion_Information.SetActive(true);
                isInformation = true;
            }
            
            else
            {
                onion_Information.SetActive(false);
                isInformation = false;
            }
        }

    }
}
