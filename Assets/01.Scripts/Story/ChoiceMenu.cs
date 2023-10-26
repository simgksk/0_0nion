using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiceMenu : MonoBehaviour
{
    [SerializeField] GameObject[] choiceButton;
    [SerializeField] GameObject choicePanel;

    Narration_2 narration2;

    void Start()
    {
        narration2 = FindObjectOfType<Narration_2>();
    }

    public void Choice(int choiceIndex)
    {
        if(choiceIndex == 1)
        {
            choicePanel.SetActive(false);
            narration2.Narration2();
            
        }

        if(choiceIndex == 2)
        {
            choicePanel.SetActive(false);
            narration2.Narration2();
        }

        if(choiceIndex == 3)
        {
            choicePanel.SetActive(false);
            narration2.Narration2();
        }
    }
}
