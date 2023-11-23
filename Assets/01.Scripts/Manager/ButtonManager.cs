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

    [SerializeField] GameObject stopMiniGamePanel;

    [SerializeField] GameObject workTimer;
    [SerializeField] GameObject workGetPayPanel;

    [SerializeField] GameObject exitMiniGame;
    [SerializeField] GameObject clickMiniGamePanel;
    [SerializeField] GameObject miniGame;
    [SerializeField] GameObject miniGame_Spawn;

    /*[SerializeField] GameObject buyPanel;
    [SerializeField] GameObject cantBuyPanel;
    [SerializeField] GameObject yesBuyPanel;
    [SerializeField] GameObject purpleOnion;
    [SerializeField] GameObject image;*/

    Water waterAnim;
    WorkTime workTime;
    DirtySpawner dirtySpawner;

    bool isPanel;

    private void Awake()
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

    public void Exit_MiniGame()
    {
        stopMiniGamePanel.SetActive(true);
    }

    public void StopMiniGame_Yes()
    {
        stopMiniGamePanel.SetActive(false);
        //SceneManager.LoadScene(2);
    }
    
    public void StopMiniGame_No()
    {
        stopMiniGamePanel.SetActive(false);
    }

    public void MiniGamePanel_YesButton()
    {
        //int rd = Random.Range(3, 5);
        //SceneManager.LoadScene(3);
        miniGame.SetActive(true);
    }
    
    public void Work_YesButton()
    {
        //workPanel.SetActive(false);
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
        miniGame_Spawn.SetActive(true);
    }

    
    [System.Serializable]
    public class BuyObject
    {
        [System.Serializable]
        public class Buy2500
        {
            public GameObject buyPanel;
            [SerializeField] GameObject cantBuyPanel;
            [SerializeField] GameObject yesBuyPanel;
            [SerializeField] GameObject purpleOnion;
            [SerializeField] GameObject image;

            public void ClickBuyButton() { buyPanel.SetActive(true); }
            public void Yes()
            {

            }
        }

    }

}
