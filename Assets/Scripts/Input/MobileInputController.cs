using UnityEngine;

namespace Input
{
    public class MobileInputController : InputController
    {
        public override Vector2 Axis => SimpleInputAxis();
    }
}