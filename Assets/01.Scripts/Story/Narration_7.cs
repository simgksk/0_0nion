using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Narration_7 : MonoBehaviour
{
    [SerializeField] GameObject narration7Panel;
    ChangeBackGround backGround;

    private void Start()
    {
        backGround = FindObjectOfType<ChangeBackGround>();
    }

    public void PanelOn()
    {
        backGround.ChangeBackGround5_Off();
        narration7Panel.SetActive(true);
    }
}
