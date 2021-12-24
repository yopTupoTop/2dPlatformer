using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Input
{
    public abstract class InputController : IInput
    {
        protected const string Horizontal = "Horizontal";
        protected const string Vertical = "Vertical";
        private const string Button = "Attack";
        public abstract Vector2 Axis { get; }

        public bool IsAttackButtonUp() => 
            SimpleInput.GetButtonUp(Button);

        protected Vector2 SimpleInputAxis() => 
            new Vector2(SimpleInput.GetAxis(Horizontal), SimpleInput.GetAxis(Vertical));
    }
}
