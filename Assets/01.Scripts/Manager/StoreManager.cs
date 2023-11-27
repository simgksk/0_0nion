using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Objects
{
    Purple,
    Fishes,
    Image1,
    Image2,
    Image3,
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

    [Header("Image1----------------------------------------------")]
    [SerializeField] GameObject image1;
    [SerializeField] GameObject image1_Sold;
    [SerializeField] GameObject image1_CantBuy;
    
    [Header("Image2----------------------------------------------")]
    [SerializeField] GameObject image2;
    [SerializeField] GameObject image2_Sold;
    [SerializeField] GameObject image2_CantBuy;
    
    [Header("Image3----------------------------------------------")]
    [SerializeField] GameObject image3;
    [SerializeField] GameObject image3_Sold;
    [SerializeField] GameObject image3_CantBuy;

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
                    GameManager.Instance().AddGood(150);
                    int myResult1 = GameManager.Instance().GetGood();
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
                    GameManager.Instance().AddGood(100);
                    int myResult1 = GameManager.Instance().GetGood();
                    fishes.SetActive(true);
                    fishes_Sold.SetActive(true);
                }
                else
                {
                    fishes_CantBuy.SetActive(true);
                }
                break;
            
            case Objects.Image1:
                if(GameManager.Instance().coin >= 500)
                {
                    GameManager.Instance().MinusCoin(500);
                    GameManager.Instance().AddGood(50);
                    int myResult1 = GameManager.Instance().GetGood();
                    image1.SetActive(true);
                    image1_Sold.SetActive(true);
                }
                else
                {
                    image1_CantBuy.SetActive(true);
                }
                break;
            
            case Objects.Image2:
                if(GameManager.Instance().coin >= 500)
                {
                    GameManager.Instance().MinusCoin(500);
                    GameManager.Instance().AddGood(50);
                    int myResult1 = GameManager.Instance().GetGood();
                    image2.SetActive(true);
                    image2_Sold.SetActive(true);
                }
                else
                {
                    image2_CantBuy.SetActive(true);
                }
                break; 
            
            case Objects.Image3:
                if(GameManager.Instance().coin >= 500)
                {
                    GameManager.Instance().MinusCoin(500);
                    GameManager.Instance().AddGood(50);
                    int myResult1 = GameManager.Instance().GetGood();
                    image3.SetActive(true);
                    image3_Sold.SetActive(true);
                }
                else
                {
                    image3_CantBuy.SetActive(true);
                }
                break;
            
            case Objects.Books:
                if(GameManager.Instance().coin >= 500)
                {
                    GameManager.Instance().MinusCoin(500);
                    GameManager.Instance().AddGood(50);
                    int myResult1 = GameManager.Instance().GetGood();
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
            
            case Objects.Image1:
                image1_CantBuy.SetActive(false);
                break; 
            
            case Objects.Image2:
                image2_CantBuy.SetActive(false);
                break;
            
            case Objects.Image3:
                image3_CantBuy.SetActive(false);
                break; 
            
            case Objects.Books:
                books_CantBuy.SetActive(false);
                break;
        }
    }
}
