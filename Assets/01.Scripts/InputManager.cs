using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InputManager : MonoBehaviour
{
    public Action onMouseDown;

    void Update()
    {
        MouseDown();
    }

    private void MouseDown()
    {
        if (Input.GetMouseButtonDown(0))
            onMouseDown?.Invoke();
    }
}
