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
    [SerializeField] GameObject workPanel;
    [SerializeField] GameObject settingPanel;
    [SerializeField] GameObject inputFieldPanel;
    [SerializeField] GameObject exitMiniGame;

    Water waterAnim;

    private void Start()
    {
        waterAnim = FindObjectOfType<Water>();
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
    
    public void MiniGamePanel_YesButton()
    {
        SceneManager.LoadScene(3);
    }

    public void WorkPanel()
    {
        workPanel.SetActive(true);
    }

    public void Work_NoButton()
    {
        workPanel.SetActive(false);
    }

    public void SettingPanel()
    {
        settingPanel.SetActive(true);
    }
    
    public void SettingPanel_Off()
    {
        settingPanel.SetActive(false);
    }

    public void Exit_MiniGame()
    {
        SceneManager.LoadScene(2);
    }

    
}
