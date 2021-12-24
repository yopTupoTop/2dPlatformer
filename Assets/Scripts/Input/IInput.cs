using UnityEngine;

namespace Input
{
   public interface IInput
   {
      Vector2 Axis { get;  }

      bool IsAttackButtonUp();
   }
}
