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

    Icon icon;

    private void Awake()
    {
        icon = FindObjectOfType<Icon>();
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

    public void Panel_Off()
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
    
    public void Panel_On()
    {
        switch (ic0n)
        {
            case Ic0o0n.Water:
                waterPanel.SetActive(false);
                //물주는 애니메이션
                break;

            case Ic0o0n.MiniGame:
                miniGamePanel.SetActive(false);
                //미니게임 연결
                break;

            case Ic0o0n.Work:
                workPanel.SetActive(false);
                //잠그는 판넬 연결
                break;
        }
    }
}
