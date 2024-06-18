using System;
using UnityEngine;

namespace Assets
{
    public class KeyboardGameplayInput
    {
        public event Action<Vector2> RotationInputReceived;
        public KeyboardGameplayInput(GameInput control)
        {
            control.KeyboardAndMouse.MouseDelta.performed += context =>
            {
                var mouseDelta = context.ReadValue<Vector2>();

                RotationInputReceived?.Invoke(mouseDelta);
            };
        }
    }
}
