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
    RandomTextBox randomTextBox;
    Onion onion;
    InputManager inputManager;

    [Header("Work----------------------------------------------")]
    [SerializeField] GameObject wokeTimePrefab;
    [SerializeField] GameObject stopSound;
    [SerializeField] GameObject onion_Information;

    [Header("Chat----------------------------------------------")]
    [SerializeField] GameObject chatBox;

    private void Awake()
    {
        icon = FindObjectOfType<Icon>();
        miniGameManager = GetComponent<MiniGameManager>();
        workTime = FindObjectOfType<WorkTime>();
        water = FindObjectOfType<Water>();
        randomTextBox = FindObjectOfType<RandomTextBox>();
        onion = FindObjectOfType<Onion>();
        
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
                onion_Information.GetComponentInChildren<InputManager>().enabled = false;
                break;

            case Ic0o0n.Chat:
                chatPanel.SetActive(true);
                icon.Icon_Off2();
                onion.enabled = false;
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
                onion_Information.GetComponentInChildren<InputManager>().enabled = true;
                break;

            case Ic0o0n.Chat:
                chatPanel.SetActive(false);
                icon.Icon_On();
                chatBox.SetActive(false);
                randomTextBox.RandomTextBoxs_Off();
                onion.enabled = true;
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
                GameObject worktime = Instantiate(wokeTimePrefab, transform);
                stopSound.SetActive(false);
                onion_Information.GetComponentInChildren<InputManager>().enabled = false;
                Invoke("SoundPlay", 12);
                Invoke("InformationOn", 20);
                break;
        }
    }

    void SoundPlay()
    {
        onion_Information.GetComponentInChildren<InputManager>().enabled = true;
        stopSound.SetActive(true);
    }
    
    void InformationOn()
    {
        onion_Information.GetComponentInChildren<InputManager>().enabled = true;
    }
}
