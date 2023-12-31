using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGameManager : MonoBehaviour
{
    
    [SerializeField] GameObject panel_TapToStart;
    [SerializeField] GameObject object_Dirty;
    [SerializeField] GameObject closePanel;
    GameObject miniGame;
    [SerializeField] GameObject miniGameSound;

    Icon icon;
    Icons icons;

    private void Awake()
    {
        icon = FindObjectOfType<Icon>();
        icons = FindObjectOfType<Icons>();
        miniGame = GameObject.FindWithTag("MiniGamePrefab");
    }
    private void Start()
    {
        miniGameSound.SetActive(true);
    }

    public void TapToStart_Button() 
    { 
        panel_TapToStart.SetActive(false); 
        object_Dirty.SetActive(true); 
    }

    public void Clear()
    {
        Destroy(miniGame);
        GameManager.Instance().AddCoin(200);
        int myResult = GameManager.Instance().GetCoin();
        GameManager.Instance().AddGood(100);
        int myResult1 = GameManager.Instance().GetGood();
        icon.Icon_On2();
        icon.Icon_On3();
    }

    public void Close_Button() { closePanel.SetActive(true); }
    
    public void Close_Yes()
    {
        closePanel.SetActive(false);
        miniGameSound.SetActive(false);
        Destroy(miniGame);
        icon.Icon_On3();
    }

    public void Close_No() { closePanel.SetActive(false); }
}
