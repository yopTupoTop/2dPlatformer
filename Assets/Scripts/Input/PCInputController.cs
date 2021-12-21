using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCInputController : IInput
{
    public void Update()
    {
        Vector2 resVector = Vector2.zero;
        
        if (UnityEngine.Input.GetKey(KeyCode.W)) resVector += Vector2.up;
        if (UnityEngine.Input.GetKey(KeyCode.A)) resVector += Vector2.left;
        if (UnityEngine.Input.GetKey(KeyCode.S)) resVector += Vector2.down;
        if (UnityEngine.Input.GetKey(KeyCode.D)) resVector += Vector2.right;
    }
}
