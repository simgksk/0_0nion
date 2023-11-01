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

    InputManager input;

    private void Awake()
    {
        input = FindObjectOfType<InputManager>();
    }

    private void Start()
    {
        input.onGetKey_Esc += GetKey_Esc;
    }

    private void OnDestroy()
    {
        input.onGetKey_Esc -= GetKey_Esc;
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

    public void Talk_Off()
    {
        talkPanel.SetActive(false);

        talkIcon.SetActive(true);
        waterIcon.SetActive(true);
        storeIcon.SetActive(true);
        minigameIcon.SetActive(true);
        workIcon.SetActive(true);
        coinIcon.SetActive(true);

    }
}
