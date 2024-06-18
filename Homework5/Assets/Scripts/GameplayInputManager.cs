using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets
{
    public class GameplayInputManager : MonoBehaviour
    {
        public event Action<Vector2> RotationInputReceived;

        [SerializeField] private RectTransform[] rotationInputZone;
        private GameInput control;

        private TouchscreenGameplayInput touchscreenGameplay;
        private KeyboardGameplayInput keyboardGameplay;

        private void Awake()
        {
            control = new GameInput();
            control.Enable();

            InitTouchscreenInput(control);
            InitKeyboardInput(control);
        }

        private void InitTouchscreenInput(GameInput control)
        {
            touchscreenGameplay = new TouchscreenGameplayInput(control, rotationInputZone);
            touchscreenGameplay.RotationInputReceived += OnRotationInputReceived;
        }

        private void InitKeyboardInput(GameInput control)
        {
            keyboardGameplay = new KeyboardGameplayInput(control);
            keyboardGameplay.RotationInputReceived += OnRotationInputReceived;
        }

        private void OnRotationInputReceived(Vector2 delta)
        {
            RotationInputReceived?.Invoke(delta);
        }
    }
}
