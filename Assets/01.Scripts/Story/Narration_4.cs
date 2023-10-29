using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Narration_4 : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI chat4;
    [SerializeField] GameObject narration4Panel;

    string write;

    public void Narration4()
    {
        narration4Panel.SetActive(true);
        StartCoroutine(Text());
    }

    IEnumerator Text()
    {
        yield return StartCoroutine(Narration("(��Ʈ ����)"));
        yield return StartCoroutine(Narration("�ϴ� ���� ���ĸ� ����"));

    }

    IEnumerator Narration(string narration)
    {
        write = "";

        for (int i = 0; i < narration.Length; i++)
        {
            write += narration[i];
            chat4.text = write;
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
