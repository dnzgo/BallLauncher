using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BallHandler : MonoBehaviour
{

    void Start()
    {
        
    }


    void Update()
    {
        if (!Touchscreen.current.primaryTouch.press.isPressed)
        {
            return;
        }
        Vector2 touchPos = Touchscreen.current.primaryTouch.position.ReadValue();

        Debug.Log(touchPos);

    }
}
