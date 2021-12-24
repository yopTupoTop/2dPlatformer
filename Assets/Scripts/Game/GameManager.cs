using System.Collections;
using System.Collections.Generic;
using Input;
using Input.Enums;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private InputType _type;
    public static IInput Input;

    public GameManager()
    {
        RegisterInput();
    }

    private void RegisterInput()
    {
        if (_type == InputType.PC)
            Input = new PCInputController();
        else
        {
            Input = new MobileInputController();
        }
    }
}
