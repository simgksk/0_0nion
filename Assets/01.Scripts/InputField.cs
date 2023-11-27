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
        textBox.RandomTextBoxs();
        int rd = Random.Range(5, 20);
        GameManager.Instance().AddGood(rd);
        int myResult1 = GameManager.Instance().GetGood();
    }
}
