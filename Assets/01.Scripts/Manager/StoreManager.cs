using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Objects
{
    Purple,
    Fishes,
    Image,
    Books
}

public class StoreManager : MonoBehaviour
{
    public Objects objects;

    [Header("PurpleOnion----------------------------------------------")]
    [SerializeField] GameObject purpleOnion;
    [SerializeField] GameObject purpleOnion_Sold;
    [SerializeField] GameObject purpleOnion_CantBuy;

    [Header("Fish----------------------------------------------")]
    [SerializeField] GameObject fishes;
    [SerializeField] GameObject fishes_Sold;
    [SerializeField] GameObject fishes_CantBuy;

    [Header("Image----------------------------------------------")]
    [SerializeField] GameObject image;
    [SerializeField] GameObject image_Sold;
    [SerializeField] GameObject image_CantBuy;

    [Header("Book----------------------------------------------")]
    [SerializeField] GameObject books;
    [SerializeField] GameObject books_Sold;
    [SerializeField] GameObject books_CantBuy;

    public void Buy()
    {
        switch (objects)
        {
            case Objects.Purple:
                if(GameManager.Instance().coin >= 2500)
                {
                    GameManager.Instance().MinusCoin(2500);
                    purpleOnion.SetActive(true);
                    purpleOnion_Sold.SetActive(true);
                }
                else
                {
                    purpleOnion_CantBuy.SetActive(true);
                }
                break;
            
            case Objects.Fishes:
                if(GameManager.Instance().coin >= 2000)
                {
                    GameManager.Instance().MinusCoin(2000);
                    fishes.SetActive(true);
                    fishes_Sold.SetActive(true);
                }
                else
                {
                    fishes_CantBuy.SetActive(true);
                }
                break;
            
            case Objects.Image:
                if(GameManager.Instance().coin >= 500)
                {
                    GameManager.Instance().MinusCoin(500);
                    image.SetActive(true);
                    image_Sold.SetActive(true);
                }
                else
                {
                    image_CantBuy.SetActive(true);
                }
                break;
            
            case Objects.Books:
                if(GameManager.Instance().coin >= 500)
                {
                    GameManager.Instance().MinusCoin(500);
                    books.SetActive(true);
                    books_Sold.SetActive(true);
                }
                else
                {
                    books_CantBuy.SetActive(true);
                }
                break;

        }
    }

    public void CantBuyPanelOff()
    {
        switch (objects)
        {
            case Objects.Purple:
                purpleOnion_CantBuy.SetActive(false);
                break;
            
            case Objects.Fishes:
                fishes_CantBuy.SetActive(false);
                break;
            
            case Objects.Image:
                image_CantBuy.SetActive(false);
                break; 
            
            case Objects.Books:
                books_CantBuy.SetActive(false);
                break;
        }
    }
}
