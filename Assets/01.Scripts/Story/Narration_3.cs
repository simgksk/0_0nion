using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Narration_3 : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI chat2;
    [SerializeField] GameObject narration3Panel;

    string write;

    public void Narration3()
    {
        narration3Panel.SetActive(true);
        StartCoroutine(Text());
    }

    IEnumerator Text()
    {
        yield return StartCoroutine(Narration("(¶Ñ¹÷¶Ñ¹÷)"));
        
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
