using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Assets
{
    public class TouchscreenGameplayInput
    {
        public event Action<Vector2> RotationInputReceived;
        private readonly Control control;
        private readonly RectTransform[] inputRotationZone;

        public TouchscreenGameplayInput(Control control, RectTransform[] inputRotationZone)
        {
            this.control = control;
            this.inputRotationZone = inputRotationZone;

            this.control.Touchscreen.TouchPress.started += OnTouchPressStarted;
            this.control.Touchscreen.TouchPress.canceled += OnTouchPressCanceled;

            //this.control.Touchscreen.TouchDelta.performed += OnTouchDeltaPerformed;
        }


        private void OnTouchPressStarted(InputAction.CallbackContext context)
        {
            var currentTouchPosition = control.Touchscreen.TouchPosition.ReadValue<Vector2>();
            var pozitiveRotationZone = true;
            foreach (var item in inputRotationZone)
            {
                var isTouchInRect = RectTransformUtility.RectangleContainsScreenPoint(item, currentTouchPosition);
                if (isTouchInRect)
                {
                    pozitiveRotationZone = false;
                    break;
                }
            }

            if (pozitiveRotationZone)
            {
                control.Touchscreen.TouchDelta.performed += OnTouchDeltaPerformed;

            }
        }

        private void OnTouchPressCanceled(InputAction.CallbackContext context)
        {
            control.Touchscreen.TouchDelta.performed -= OnTouchDeltaPerformed;

        }
        private void OnTouchDeltaPerformed(InputAction.CallbackContext context)
        {
            RotationInputReceived?.Invoke(context.ReadValue<Vector2>());
        }
    }
}
