using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputController : MonoBehaviour
{
    public float gravity = -9.81f;
    public float speed = 10.0f;
    CharacterController characterController;
    private IControllable controllable;
    private Control control;
    public Joystick joystick;
    public CharacterController CharacterController{ get { return characterController = characterController ?? GetComponent<CharacterController>(); } }




}
