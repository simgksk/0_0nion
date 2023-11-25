using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGameManager : MonoBehaviour
{
    [SerializeField] GameObject miniGame_1;
    [SerializeField] GameObject panel_TapToStart;
    [SerializeField] GameObject object_Dirty;
    [SerializeField] GameObject closePanel;

    Icon icon;

    bool isClear = true;

    private void Awake()
    {
        icon = FindObjectOfType<Icon>();
    }

    public void MiniGame1()
    {
        GameObject minigame1 = Instantiate(miniGame_1, transform);
    }

    public void TapToStart_Button() 
    { 
        panel_TapToStart.SetActive(false); 
        object_Dirty.SetActive(true); 
    }

    public void Clear()
    {
        Destroy(miniGame_1);
    }

    public void Close_Button() { closePanel.SetActive(true); }
    
    public void Close_Yes()
    {
        closePanel.SetActive(false);
        Destroy(miniGame_1);
    }

    public void Close_No() { closePanel.SetActive(false); }
}
