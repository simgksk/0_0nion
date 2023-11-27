using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ending : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI ending;

    string write;

    private void Start()
    { 
        StartCoroutine(Text());
    }

    IEnumerator Text()
    {
        yield return StartCoroutine(Narration("�׵��� ������"));
        yield return StartCoroutine(Narration("ó������ �� �丮 �ظԴ°� �ƴұ��� �ǽ��� �߾�����"));
        yield return StartCoroutine(Narration("�� ���� ����̾�"));
        yield return StartCoroutine(Narration("���� ���� ������ �־��� ������ ���ؼ� ���� ��������"));
        yield return StartCoroutine(Narration("���߿� �츮 �ٽ� ���� �� �����ž�"));
        yield return StartCoroutine(Narration("�츮 �ٽ� ���� ������ ������������"));
        yield return StartCoroutine(Narration("�� ����"));
        yield return StartCoroutine(Narration("�ȳ�"));
        SceneManager.LoadScene(0);
    }

    IEnumerator Narration(string narration)
    {
        write = "";

        for (int i = 0; i < narration.Length; i++)
        {
            write += narration[i];
            ending.text = write;
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
