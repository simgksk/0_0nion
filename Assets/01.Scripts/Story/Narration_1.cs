using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Narration_1 : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI chat;
    [SerializeField] GameObject choiceMenu;
    [SerializeField] GameObject text; 
    string write;

    void Start()
    {
        text.SetActive(false);
        StartCoroutine("Text");
    }

    IEnumerator Text()
    {
        yield return new WaitForSeconds(1f);
        text.SetActive(true);
        yield return StartCoroutine(Narration("¾Æ... Èûµé´Ù"));
        yield return StartCoroutine(Narration("¿À´Ã Àú³áÀº ¹¹ ¸ÔÁö?"));
        yield return StartCoroutine(Narration("¹» ¸ÔÀ»±î?"));
        Destroy(chat);
        ChoiceMenu();
    }

    IEnumerator Narration(string narration)
    {
        write = "";

        for(int i=0; i<narration.Length; i++)
        {
            write += narration[i];
            chat.text = write;
            yield return new WaitForSeconds(.05f);
        }

        while (true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                break;
            }

            yield return null;
        }
    }

    void ChoiceMenu()
    {
        choiceMenu.SetActive(true);
    }

}
