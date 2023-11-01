using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InputManager : MonoBehaviour
{
    public Action onMouseDown;
    public Action onGetKey_Esc;

    void Update()
    {
        MouseDown();
        GetKeyDown_ESC();
    }

    private void GetKeyDown_ESC()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            onGetKey_Esc?.Invoke();
    }

    private void MouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            onMouseDown?.Invoke();
        }
    }
}
