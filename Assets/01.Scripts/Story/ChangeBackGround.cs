using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBackGround : MonoBehaviour
{
    [SerializeField] GameObject bg1;
    [SerializeField] GameObject bg2;
    [SerializeField] GameObject bg3;
    [SerializeField] GameObject bg4;
    [SerializeField] GameObject bg5;

    public void ChangeBackGround1()
    {
        bg1.SetActive(true);
    }
    
    public void ChangeBackGround1_Off()
    {
        bg1.SetActive(false);
    }
    
    public void ChangeBackGround2()
    {
        bg2.SetActive(true);
    }
    
    public void ChangeBackGround2_Off()
    {
        bg2.SetActive(false);
    }
    
    public void ChangeBackGround3()
    {
        bg3.SetActive(true);
    }
    
    public void ChangeBackGround3_Off()
    {
        bg3.SetActive(false);
    }
    
    public void ChangeBackGround4()
    {
        bg4.SetActive(true);
    }
    
    public void ChangeBackGround4_Off()
    {
        bg4.SetActive(false);
    }
    
    public void ChangeBackGround5()
    {
        bg5.SetActive(true);
    }
}
