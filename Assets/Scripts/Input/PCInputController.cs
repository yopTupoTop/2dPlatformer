using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Input
{
    public class PCInputController : InputController
    {
        public override Vector2 Axis
        {
            get
            {
                Vector2 axis = SimpleInputAxis();

                if (axis == Vector2.zero)
                    axis = UnityAxis();
                return axis;
            }
        }

        private static Vector2 UnityAxis() => 
            new Vector2(UnityEngine.Input.GetAxis(Horizontal), UnityEngine.Input.GetAxis(Vertical));
    }
}
