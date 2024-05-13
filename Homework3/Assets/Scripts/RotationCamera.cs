using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationCamera : MonoBehaviour
{
    public Camera mainCamera;

    public Vector3 targetPosition;
    public Vector3 targetRotation;

    public void ChangeCameraPositionAndRotation()
    {
        mainCamera.transform.localPosition = targetPosition;
        mainCamera.transform.localRotation = Quaternion.Euler(targetRotation);
    }

}
