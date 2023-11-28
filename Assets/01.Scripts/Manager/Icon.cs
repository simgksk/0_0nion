using UnityEngine;

public class Icon : MonoBehaviour
{
    [SerializeField] GameObject waterIcon;
    [SerializeField] GameObject storeIcon;
    [SerializeField] GameObject chatIcon;
    [SerializeField] GameObject minigameIcon;
    [SerializeField] GameObject workIcon;
    [SerializeField] GameObject nameBox;
    [SerializeField] GameObject waterBox;
    [SerializeField] GameObject onion;
    [SerializeField] GameObject bgm;

    public void Icon_Off()
    {
        waterIcon.SetActive(false);
        storeIcon.SetActive(false);
        chatIcon.SetActive(false);
        minigameIcon.SetActive(false);
        workIcon.SetActive(false);
        nameBox.SetActive(false);
        waterBox.SetActive(false);
        onion.SetActive(false);
    }
    
    public void Icon_Off2()
    {
        waterIcon.SetActive(false);
        storeIcon.SetActive(false);
        chatIcon.SetActive(false);
        minigameIcon.SetActive(false);
        workIcon.SetActive(false);
        nameBox.SetActive(false);
        waterBox.SetActive(false);
    }
    
    public void Icon_On()
    {
        waterIcon.SetActive(true);
        storeIcon.SetActive(true);
        chatIcon.SetActive(true);
        minigameIcon.SetActive(true);
        workIcon.SetActive(true);
        nameBox.SetActive(true);
        waterBox.SetActive(true);
        onion.SetActive(true);
    }
    
    public void Icon_On2()
    {
        waterIcon.SetActive(true);
        storeIcon.SetActive(true);
        chatIcon.SetActive(true);
        minigameIcon.SetActive(true);
        workIcon.SetActive(true);
        nameBox.SetActive(true);
        //waterBox.SetActive(true);
        onion.SetActive(true);
    }
    
    public void Icon_On3()
    {
        waterIcon.SetActive(true);
        storeIcon.SetActive(true);
        chatIcon.SetActive(true);
        minigameIcon.SetActive(true);
        workIcon.SetActive(true);
        nameBox.SetActive(true);
        bgm.SetActive(true);
        onion.SetActive(true);
    }
}
