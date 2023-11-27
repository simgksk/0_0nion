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
        yield return StartCoroutine(Narration("그동안 고마웠어"));
        yield return StartCoroutine(Narration("처음에는 날 요리 해먹는게 아닐까라는 의심을 했었지만"));
        yield return StartCoroutine(Narration("넌 좋은 사람이야"));
        yield return StartCoroutine(Narration("나는 이제 나에게 주어진 수명을 다해서 먼저 떠나지만"));
        yield return StartCoroutine(Narration("나중에 우리 다시 만날 수 있을거야"));
        yield return StartCoroutine(Narration("우리 다시 만날 때까지 슬퍼하지말고"));
        yield return StartCoroutine(Narration("잘 지내"));
        yield return StartCoroutine(Narration("안녕"));
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
