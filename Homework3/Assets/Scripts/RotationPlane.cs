using UnityEngine;

public class RotationPlane : MonoBehaviour
{
    private bool isRotating = false;
    private Vector2 lastTouchPosition;
    private Vector3 defultePosition = new(0.0f, 0.0f, 0.0f);
    private float returnSpeed = 5.0f;
    public float rotationSpeed = 20.0f;

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                lastTouchPosition = touch.position;
                isRotating = true;
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                isRotating = false;
            }
            else if (touch.phase == TouchPhase.Moved && isRotating)
            {
                float touchDelta = touch.position.x - lastTouchPosition.x;

                transform.Rotate(Vector3.up, touchDelta * rotationSpeed * Time.deltaTime);

                lastTouchPosition = touch.position;
            }
        }
        else
        {
            transform.localRotation = Quaternion.Lerp(transform.localRotation, Quaternion.Euler(defultePosition), returnSpeed * Time.deltaTime);
        }
    }
}
