using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] GameObject onionInformaition;
    [SerializeField] GameObject waterPanel;
    [SerializeField] GameObject storePanel;
    [SerializeField] GameObject miniGamePanel;

    public void Informaition_Close()
    {
        onionInformaition.SetActive(false);
    }

    public void WaterPanel()
    {
        waterPanel.SetActive(true);
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

    public void Start_Button()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit_Button()
    {
        Debug.Log("Á¾·á");
        Application.Quit();
    }
}
