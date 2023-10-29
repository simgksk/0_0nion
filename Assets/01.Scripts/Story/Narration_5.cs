using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Narration_5 : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI chat5;
    [SerializeField] GameObject narration5Panel;

    Narration_6 narration6;
    ChangeBackGround backGround;

    string write;

    private void Start()
    {
        narration6 = FindObjectOfType<Narration_6>();
        backGround = FindObjectOfType<ChangeBackGround>();
    }

    public void Narration5()
    {
        StartCoroutine(Text());
    }

    IEnumerator Text()
    {
        backGround.ChangeBackGround2_Off();
        backGround.ChangeBackGround3();

        narration5Panel.SetActive(false);
        Invoke("FadeBG", 2);
        yield return StartCoroutine(Narration(""));
    }

    private void FadeBG()
    {
        backGround.ChangeBackGround3_Off();
        backGround.ChangeBackGround4();
        StartCoroutine(Text2());   
    }

    IEnumerator Text2()
    {
        yield return new WaitForSeconds(2);
        narration5Panel.SetActive(true);
        yield return StartCoroutine(Narration("뭐지...?"));
        yield return StartCoroutine(Narration("이 우울해 보이는 양파는?"));
        yield return StartCoroutine(Narration("흠..."));
        yield return StartCoroutine(Narration("양파 한 번 키워볼까?"));
        yield return StartCoroutine(Narration("이 우울해 보이는 양파를 키워 보겠어!"));
        Destroy(chat5);
        narration6.Narration6();
    }

    IEnumerator Narration(string narration)
    {
        write = "";

        for (int i = 0; i < narration.Length; i++)
        {
            write += narration[i];
            chat5.text = write;
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
}
