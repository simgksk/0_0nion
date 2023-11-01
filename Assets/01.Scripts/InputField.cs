using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InputField : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI inputText;
    [SerializeField] GameObject inputTextP;

    RandomTextBox textBox;

    private void Start()
    {
        textBox = FindObjectOfType<RandomTextBox>();
    }

    public void Enter()
    {
        //inputTextP.SetActive(false);
        textBox.RandomTextBoxs();
    }

    public void Click()
    {
        //inputTextP.SetActive(true); 
    }
}
