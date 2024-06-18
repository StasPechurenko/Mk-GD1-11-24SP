using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterInputController : MonoBehaviour
{
    private IControllable _controllable;
    private GameInput _gameInput;

    private void Awake()
    {
        _gameInput = new GameInput();
        _gameInput.Enable();
        _controllable = GetComponent<IControllable>();
    }

    private void OnEnable()
    {
        _gameInput.Gameplay.Jump.performed += JumpOnPerformed;
    }

    private void JumpOnPerformed(InputAction.CallbackContext ctx)
    {
        _controllable.Jump();
    }

    private void OnDisable()
    {
        _gameInput.Gameplay.Jump.performed -= JumpOnPerformed;
    }

    private void Update()
    {
        ReadMovement();
    }

    private void ReadMovement()
    {
        var inputDirection = _gameInput.Gameplay.Movement.ReadValue<Vector2>();
        var direction = new Vector3(inputDirection.x, 0f, inputDirection.y);
        _controllable.Move(direction);
    }
}
