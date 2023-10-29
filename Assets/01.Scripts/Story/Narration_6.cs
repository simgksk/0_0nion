using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Narration_6 : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI chat6;
    [SerializeField] GameObject narration6Panel;

    ChangeBackGround backGround;

    string write;

    private void Start()
    {
        backGround = FindObjectOfType<ChangeBackGround>();
    }

    public void Narration6()
    {
        narration6Panel.SetActive(true);
        StartCoroutine(Text());
    }

    IEnumerator Text()
    {
        backGround.ChangeBackGround4_Off();
        backGround.ChangeBackGround5();
        yield return StartCoroutine(Narration("(드디어 집이다)"));
        yield return StartCoroutine(Narration("양파의 이름을 먼저 지어주자!"));
        Destroy(chat6);

    }

    IEnumerator Narration(string narration)
    {
        write = "";

        for (int i = 0; i < narration.Length; i++)
        {
            write += narration[i];
            chat6.text = write;
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
