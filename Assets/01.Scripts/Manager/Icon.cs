using UnityEngine;

public class Icon : MonoBehaviour
{
    [SerializeField] GameObject talkPanel;
    [SerializeField] GameObject talkIcon;
    [SerializeField] GameObject waterIcon;
    [SerializeField] GameObject storeIcon;
    [SerializeField] GameObject minigameIcon;
    [SerializeField] GameObject workIcon;
    [SerializeField] GameObject coinIcon;
    [SerializeField] GameObject nameBox;

    InputManager input;
    RandomTextBox textBox;

    private void Awake()
    {
        input = FindObjectOfType<InputManager>();
        textBox = FindObjectOfType<RandomTextBox>();
    }

    private void Start()
    {
        input.onGetKey_Esc += GetKey_Esc;
    }

    private void OnDestroy()
    {
        input.onGetKey_Esc -= GetKey_Esc;
    }

    public void Talk_On()
    {
        talkPanel.SetActive(true);

        talkIcon.SetActive(false);
        waterIcon.SetActive(false);
        storeIcon.SetActive(false);
        minigameIcon.SetActive(false);
        workIcon.SetActive(false);
        coinIcon.SetActive(false);
    }

    private void GetKey_Esc()
    {
        talkPanel.SetActive(false);

        talkIcon.SetActive(true);
        waterIcon.SetActive(true);
        storeIcon.SetActive(true);
        minigameIcon.SetActive(true);
        workIcon.SetActive(true);
        coinIcon.SetActive(true);
        textBox.RandomTextBoxs_Off();
    }

    public void Talk_Off()
    {
        talkPanel.SetActive(false);

        talkIcon.SetActive(true);
        waterIcon.SetActive(true);
        storeIcon.SetActive(true);
        minigameIcon.SetActive(true);
        workIcon.SetActive(true);
        coinIcon.SetActive(true);
        textBox.RandomTextBoxs_Off();

    }

    public void Store_On()
    {
        workIcon.SetActive(false);
    }
    
    public void Store_Off()
    {
        workIcon.SetActive(true);
    }

    public void MiniGame_On()
    {
        talkIcon.SetActive(false);
        waterIcon.SetActive(false);
        storeIcon.SetActive(false);
        workIcon.SetActive(false);
        coinIcon.SetActive(false);
        minigameIcon.SetActive(false);
        nameBox.SetActive(false);
    }
    
    public void MiniGame_Off()
    {
        talkIcon.SetActive(true);
        waterIcon.SetActive(true);
        storeIcon.SetActive(true);
        workIcon.SetActive(true);
        coinIcon.SetActive(true);
        minigameIcon.SetActive(true);
        nameBox.SetActive(true);
    }
}
