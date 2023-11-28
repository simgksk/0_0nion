using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[System.Serializable]
public class ButtonManager : MonoBehaviour
{
    [SerializeField] GameObject settingPanel;
    [SerializeField] GameObject skip;
    [SerializeField] GameObject inputFieldPanel;

    [SerializeField] GameObject onionInformaition;

    [SerializeField] GameObject exitPanelInMain;


    private void Awake()
    {
        Invoke("Skip_SetActive", 3);
    }

    public void Start_Button() { SceneManager.LoadScene(1); }

    public void Exit_Button() { Application.Quit(); }
   
    public void Skip_SetActive() { skip.SetActive(true); }
    
    public void Skip_Button() { inputFieldPanel.SetActive(true); }

    public void Informaition_Close() { onionInformaition.SetActive(false); }

    public void ExitInMain() { exitPanelInMain.SetActive(true); }
    public void ExitInMain_No() { exitPanelInMain.SetActive(false); }
    public void ExitInMain_Yes()
    {
        exitPanelInMain.SetActive(false);
        SceneManager.LoadScene(0);
    }

}
