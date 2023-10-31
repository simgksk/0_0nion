using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OnionName2 : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI onion_Name;

    private void Awake()
    {
        onion_Name.text = OnionName1.onionName1.onion_Name;
    }
}
