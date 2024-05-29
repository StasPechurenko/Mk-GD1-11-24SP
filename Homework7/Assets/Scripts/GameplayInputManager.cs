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
       // private Icontrollable icontrollable;
        private Control control;

        private TouchscreenGameplayInput touchscreenGameplay;
        private KeyboardGameplayInput keyboardGameplay;

        private void Awake()
        {
            control = new Control();
            control.Enable();

            InitTouchscreenInput(control);
            InitKeyboardInput(control);
        }

        private void InitTouchscreenInput(Control control)
        {
            touchscreenGameplay = new TouchscreenGameplayInput(control, rotationInputZone);
            touchscreenGameplay.RotationInputReceived += OnRotationInputReceived;
        }

        private void InitKeyboardInput(Control control)
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
