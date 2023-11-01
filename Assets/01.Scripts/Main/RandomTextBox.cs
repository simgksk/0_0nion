using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomTextBox : MonoBehaviour
{
    [SerializeField] GameObject[] textBoxs;
    
    public void RandomTextBoxs()
    {
        int rd = Random.Range(0, textBoxs.Length);

        textBoxs[rd].SetActive(true);
    }

    public void RandomTextBoxs_Off()
    {
        textBoxs[0].SetActive(false);
        textBoxs[1].SetActive(false);
        textBoxs[2].SetActive(false);
        textBoxs[3].SetActive(false);
    }
}
