using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Narration_4 : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI chat4;
    [SerializeField] GameObject narration4Panel;

    Narration_5 narration5;
    ChangeBackGround backGround;

    string write;

    private void Start()
    {
        narration5 = FindObjectOfType<Narration_5>();
        backGround = FindObjectOfType<ChangeBackGround>();
    }

    public void Narration4()
    {
        narration4Panel.SetActive(true);
        StartCoroutine(Text());
    }

    IEnumerator Text()
    {
        backGround.ChangeBackGround1_Off();
        backGround.ChangeBackGround2();
        yield return StartCoroutine(Narration("(마트 도착)"));
        yield return StartCoroutine(Narration("일단 먼저 양파를 사야겠다."));
        Destroy(chat4);
        narration5.Narration5();

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
