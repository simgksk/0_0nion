using UnityEngine;

public class Icon : MonoBehaviour
{
    [SerializeField] GameObject waterIcon;
    [SerializeField] GameObject storeIcon;
    [SerializeField] GameObject chatIcon;
    [SerializeField] GameObject minigameIcon;
    [SerializeField] GameObject workIcon;

    public void Icon_Off()
    {
        waterIcon.SetActive(false);
        storeIcon.SetActive(false);
        chatIcon.SetActive(false);
        minigameIcon.SetActive(false);
        workIcon.SetActive(false);
    }
    
    public void Icon_On()
    {
        waterIcon.SetActive(true);
        storeIcon.SetActive(true);
        chatIcon.SetActive(true);
        minigameIcon.SetActive(true);
        workIcon.SetActive(true);
    }
}
