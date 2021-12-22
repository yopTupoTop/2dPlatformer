using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileInputController : IInput
{
    public bool Tap = false;
    public bool SwipeLeft = false;
    public bool SwipeRight = false;
    public bool SwipeUp = false;

    private bool _isDraging = false;

    private Vector2 _startTouch;
    private Vector2 _swipeDelta;
    public void Update()
    {
        if (UnityEngine.Input.touches.Length > 0)
        {
            if (UnityEngine.Input.touches[0].phase == TouchPhase.Began)
            {
                Tap = true;
                _isDraging = true;
                _startTouch = UnityEngine.Input.touches[0].position;
            }
            else if (UnityEngine.Input.touches[0].phase == TouchPhase.Ended ||
                     UnityEngine.Input.touches[0].phase == TouchPhase.Canceled)
            {
                //_isDraging = false;
                Reset();
            }
        }
        
        _swipeDelta = Vector2.zero;

        if (_isDraging)
        {
            if (UnityEngine.Input.touches.Length < 0)
            {
                _swipeDelta = UnityEngine.Input.touches[0].position - _startTouch;
            }
        }

        if (_swipeDelta.magnitude > 100)
        {
            float x = _swipeDelta.x;
            float y = _swipeDelta.y;

            if (Mathf.Abs(x) > Mathf.Abs(y))
            {
                if (x < 0)
                    SwipeLeft = true;
                else
                    SwipeRight = true;
            }
            else
            {
                if (y > 0)
                    SwipeUp = true;
            }
        }
    }

    public void Reset()
    {
        _startTouch = _swipeDelta = Vector2.zero;
        _isDraging = false;
    }
}
