using UnityEngine;

public enum Ic0o0n
{
    Water,
    Store,
    Chat,
    MiniGame,
    Work
}

public class Icons : MonoBehaviour
{
    public Ic0o0n ic0n;

    [Header("Panel----------------------------------------------")]
    [SerializeField] GameObject waterPanel;
    [SerializeField] GameObject storePanel;
    [SerializeField] GameObject chatPanel;
    [SerializeField] GameObject miniGamePanel;
    [SerializeField] GameObject workPanel;

    [Header("MiniGame----------------------------------------------")]
    public GameObject miniGamePrefab;
    Icon icon;
    MiniGameManager miniGameManager;
    WorkTime workTime;
    Water water;

    [Header("Work----------------------------------------------")]
    [SerializeField] GameObject wokeTimePrefab;

    private void Awake()
    {
        icon = FindObjectOfType<Icon>();
        miniGameManager = GetComponent<MiniGameManager>();
        workTime = FindObjectOfType<WorkTime>();
        water = FindObjectOfType<Water>();
    }

    private void Start()
    {
       
    }

    public void ClickIcon()
    {
        switch (ic0n)
        {
            case Ic0o0n.Water:
                waterPanel.SetActive(true);
                break;
            
            case Ic0o0n.Store:
                storePanel.SetActive(true);
                icon.Icon_Off();
                break;

            case Ic0o0n.Chat:
                chatPanel.SetActive(true);
                icon.Icon_Off();
                break;
            
            case Ic0o0n.MiniGame:
                miniGamePanel.SetActive(true);
                break;
            
            case Ic0o0n.Work:
                workPanel.SetActive(true);
                break;

        }
    }

    public void Click_Button_NoAndClose()
    {
        switch (ic0n)
        {
            case Ic0o0n.Water:
                waterPanel.SetActive(false);
                break;

            case Ic0o0n.Store:
                storePanel.SetActive(false);
                icon.Icon_On();
                break;

            case Ic0o0n.Chat:
                chatPanel.SetActive(false);
                icon.Icon_On();
                break;

            case Ic0o0n.MiniGame:
                miniGamePanel.SetActive(false);
                break;

            case Ic0o0n.Work:
                workPanel.SetActive(false);
                break;
        }
    }
    
    public void Click_Button_Yes()
    {
        switch (ic0n)
        {
            case Ic0o0n.Water:
                waterPanel.SetActive(false);
                water.IncreaseWater();
                Debug.Log("need water Anim"); //물주는 애니메이션
                break;

            case Ic0o0n.MiniGame:
                miniGamePanel.SetActive(false);
                GameObject miniGame = Instantiate(miniGamePrefab);
                icon.Icon_Off();
                break;

            case Ic0o0n.Work:
                workPanel.SetActive(false);
                break;
        }
    }
}
