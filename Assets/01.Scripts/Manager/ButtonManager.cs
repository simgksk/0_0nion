using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] GameObject skip;
    [SerializeField] GameObject onionInformaition;
    [SerializeField] GameObject waterPanel;
    [SerializeField] GameObject storePanel;
    [SerializeField] GameObject miniGamePanel;
    [SerializeField] GameObject stopMiniGamePanel;
    [SerializeField] GameObject workPanel;
    [SerializeField] GameObject workTimer;
    [SerializeField] GameObject workGetPayPanel;
    [SerializeField] GameObject settingPanel;
    [SerializeField] GameObject inputFieldPanel;
    [SerializeField] GameObject exitMiniGame;
    [SerializeField] GameObject clickMiniGamePanel;

    Water waterAnim;
    WorkTime workTime;
    DirtySpawner dirtySpawner;

    private void Start()
    {
        waterAnim = FindObjectOfType<Water>();
        workTime = FindObjectOfType<WorkTime>();
        dirtySpawner = FindObjectOfType<DirtySpawner>();
        Invoke("Skip_SetActive", 3);
    }

    public void Start_Button()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit_Button()
    {
        Debug.Log("Á¾·á");
        Application.Quit();
    }
   
    public void Skip_SetActive()
    {
        skip.SetActive(true);
    }
    
    public void Skip_Button()
    {
        inputFieldPanel.SetActive(true);
    }

    public void Informaition_Close()
    {
        onionInformaition.SetActive(false);
    }

    public void WaterPanel()
    {
        waterPanel.SetActive(true);
    }
    
    public void Water_YesButton()
    {
        waterPanel.SetActive(false);
        waterAnim.Increase();
    }
    
    public void Water_NoButton()
    {
        waterPanel.SetActive(false);
    }

    public void Store_Open()
    {
        storePanel.SetActive(true);
    }
    
    public void Store_Close()
    {
        storePanel.SetActive(false);
    }

    public void MiniGamePanel()
    {
        miniGamePanel.SetActive(true);
    }
    
    public void MiniGamePanel_NoButton()
    {
        miniGamePanel.SetActive(false);
    }

    public void Exit_MiniGame()
    {
        stopMiniGamePanel.SetActive(true);
    }

    public void StopMiniGame_Yes()
    {
        stopMiniGamePanel.SetActive(false);
        SceneManager.LoadScene(2);
    }
    
    public void StopMiniGame_No()
    {
        stopMiniGamePanel.SetActive(false);
    }

    public void MiniGamePanel_YesButton()
    {
        int rd = Random.Range(3, 5);
        SceneManager.LoadScene(rd);
    }

    public void WorkPanel()
    {
        workPanel.SetActive(true);
    }

    public void Work_NoButton()
    {
        workPanel.SetActive(false);
    }
    
    public void Work_YesButton()
    {
        workPanel.SetActive(false);
        workTimer.SetActive(true);
    }

    public void Work_GetPayButton()
    {
        workGetPayPanel.SetActive(false);
        GameManager.Instance().AddCoin(1400);
        int myResult = GameManager.Instance().GetCoin();
    }

    public void SettingPanel()
    {
        settingPanel.SetActive(true);
    }
    
    public void SettingPanel_Off()
    {
        settingPanel.SetActive(false);
    }

    public void ClickMiniGame()
    {
        clickMiniGamePanel.SetActive(false);
        dirtySpawner.Spawner();
    }

}
