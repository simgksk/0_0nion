using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class OnionName1 : MonoBehaviour
{
    public static OnionName1 onionName1;
    [SerializeField] TMP_InputField inputField;

    public string onion_Name;

    private void Awake()
    {
        if(onionName1 == null)
        {
            onionName1 = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SetOnionName()
    {
        onion_Name = inputField.text;
        
        SceneManager.LoadScene(2);
    }
}
