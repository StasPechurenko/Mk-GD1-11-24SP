using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets
{
    public class CameraRotationHendler:MonoBehaviour
    {
        [SerializeField] private GameplayInputManager gameplayInput;

        [SerializeField] private Transform rotationTarget;
        [SerializeField] private float sensitivity = 15f;
        [SerializeField] private float minVerticalAngle = -30f;
        [SerializeField] private float maxVerticallAngle = 30f;

        private float horizontal = 0f;
        private float vertical = 0f;

        private void Start()
        {
            gameplayInput.RotationInputReceived += OnRotationInputReceived;
        }

        private void OnDestroy()
        {
            gameplayInput.RotationInputReceived += OnRotationInputReceived;
        }

        private void OnRotationInputReceived(Vector2 delta)
        {
            var dt = Time.deltaTime;
            vertical -= sensitivity * delta.y * dt;
            horizontal += sensitivity * delta.x * dt;

            vertical = Mathf.Clamp(vertical, minVerticalAngle, maxVerticallAngle);


            rotationTarget.localEulerAngles= new Vector3(vertical, 0f, 0f);
            transform.eulerAngles = new Vector3(0f, horizontal, 0f);
        }
    }
}
