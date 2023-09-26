using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] GameObject onionInformaition;

    public void Close_Informaition()
    {
        onionInformaition.SetActive(false);
    }
}
