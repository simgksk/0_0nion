using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Narration_2 : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI chat2;
    [SerializeField] GameObject narrationPanel;

    Narration_3 narration3;

    string write;

    private void Start()
    {
        narration3 = FindObjectOfType<Narration_3>();
    }

    public void Narration2()
    {
        narrationPanel.SetActive(true);
        StartCoroutine(Text());
    }

    IEnumerator Text()
    {
        yield return StartCoroutine(Narration("오늘 저녁은 이걸로 먹어야겠다."));
        yield return StartCoroutine(Narration("오랜만에 먹을 생각하니깐 피로가 조금이라도 풀린다..."));
        yield return StartCoroutine(Narration("일단 마트에 가서 재료를 사오자"));
        Destroy(chat2);
        narration3.Narration3();
    }

    IEnumerator Narration(string narration)
    {
        write = "";

        for (int i = 0; i < narration.Length; i++)
        {
            write += narration[i];
            chat2.text = write;
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
