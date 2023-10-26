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
        yield return StartCoroutine(Narration("���� ������ �̰ɷ� �Ծ�߰ڴ�."));
        yield return StartCoroutine(Narration("�������� ���� �����ϴϱ� �Ƿΰ� �����̶� Ǯ����..."));
        yield return StartCoroutine(Narration("�ϴ� ��Ʈ�� ���� ��Ḧ �����"));
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
