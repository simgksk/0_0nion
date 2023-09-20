using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Onion : MonoBehaviour
{
    [SerializeField] GameObject onionPanel;
    bool isPanel;

    void Start()
    {
        isPanel = onionPanel;
        onionPanel.SetActive(false);
    }

    void Update()
    {
        OnOffPanel();
    }

    private void OnOffPanel()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.E))
        {
            if (isPanel)
            {
                Debug.Log("PanelON");
                //onionPanel.SetActive(true);
            }
        }
    }
}
