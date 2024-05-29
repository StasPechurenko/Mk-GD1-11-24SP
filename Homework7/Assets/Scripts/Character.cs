using Assets;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class Character : MonoBehaviour
{
    public event Action<Vector2> InputReceived;

    [SerializeField] private float speed = 10f;
    [SerializeField] private float gravity = -9.81f;
    [SerializeField] private float jumpHeight = 3f;
    [SerializeField] private LayerMask groundMask;
    [SerializeField] private AnimationCurve jump;
    private Vector3 jumpDirection;
    private float xJump;
    private float yJump;
    private bool isJump = false;

    private CharacterController controller;
    private KeyboardGameplayInput keyboardGameplay;
    private float velosity;
    private Vector3 moveDirection;
    private bool isGrounded;

    private void Awake()
    {
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        isGrounded = controller.isGrounded;

        if (isGrounded && velosity < 0)
        {
            velosity = -2;
        }

        MoveInternal();
        DoGravity();
        Move();
        Jump();
        DoGravity();
    }

    public void Move()
    {
        moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        moveDirection = transform.TransformDirection(moveDirection);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isJump = true;
        }
    }



    public void Jump()
    {
        if (isJump)
        {
            xJump += Time.deltaTime;
            yJump = jump.Evaluate(xJump);
            jumpDirection = Vector3.up;
            controller.Move(jumpDirection * yJump * jumpHeight * Time.deltaTime);
            if (xJump >= jump.keys[jump.keys.Length-1].time)
            {
                isJump = false;
                xJump = 0f;
            }
           
        }
    }

    private void MoveInternal()
    {
        controller.Move(moveDirection * speed * Time.deltaTime);
    }

    private void DoGravity()
    {
        velosity += gravity * Time.deltaTime;
        controller.Move(Vector3.up * velosity * Time.deltaTime);
    }
}
