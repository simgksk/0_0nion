using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] GameObject onionInformaition;
    [SerializeField] GameObject waterIcon;

    public void Close_Informaition()
    {
        onionInformaition.SetActive(false);
    }

    public void Water()
    {
        
    }
}
