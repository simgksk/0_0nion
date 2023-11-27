using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomTextBox : MonoBehaviour
{
    [SerializeField] GameObject[] textBoxs;
    
    public void RandomTextBoxs()
    {
        int rd = Random.Range(0, textBoxs.Length);

        switch (rd)
        {
            case 0:
                textBoxs[0].SetActive(false);
                textBoxs[1].SetActive(true);
                textBoxs[2].SetActive(false);
                textBoxs[3].SetActive(false);
                break;
            
            case 1:
                textBoxs[0].SetActive(false);
                textBoxs[1].SetActive(false);
                textBoxs[2].SetActive(true);
                textBoxs[3].SetActive(false);
                break;
            
            case 2:
                textBoxs[0].SetActive(false);
                textBoxs[1].SetActive(false);
                textBoxs[2].SetActive(false);
                textBoxs[3].SetActive(true);
                break;
            
            case 3:
                textBoxs[0].SetActive(true);
                textBoxs[1].SetActive(false);
                textBoxs[2].SetActive(false);
                textBoxs[3].SetActive(false);
                break;
        }
    }

    public void RandomTextBoxs_Off()
    {
        textBoxs[0].SetActive(false);
        textBoxs[1].SetActive(false);
        textBoxs[2].SetActive(false);
        textBoxs[3].SetActive(false);
    }
}
