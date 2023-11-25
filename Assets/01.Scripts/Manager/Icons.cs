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
    [SerializeField] GameObject playMiniGame;

    Icon icon;
    MiniGameManager miniGameManager;

    
    private void Awake()
    {
        icon = FindObjectOfType<Icon>();
        miniGameManager = FindObjectOfType<MiniGameManager>();
    }

    private void Start()
    {
        /*waterPanel.SetActive(false);
        storePanel.SetActive(false);
        chatPanel.SetActive(false);
        miniGamePanel.SetActive(false);
        workPanel.SetActive(false);*/
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
                Debug.Log("need water Anim"); //물주는 애니메이션
                break;

            case Ic0o0n.MiniGame:
                miniGamePanel.SetActive(false);
                icon.Icon_Off();
                miniGameManager.MiniGame1();
                Debug.Log("play mini game");//미니게임 연결
                break;

            case Ic0o0n.Work:
                workPanel.SetActive(false);
                Debug.Log("setActive true panel lock");//잠그는 판넬 연결
                break;
        }
    }
}
