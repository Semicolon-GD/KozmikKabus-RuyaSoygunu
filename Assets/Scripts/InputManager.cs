using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Interactions;

public class InputManager : MonoBehaviour
{
    private PlayerInput playerInput;
    private PlayerInput.OnFootActions onFoot;
    private PlayerMotor playerMotor;
    private PlayerLook playerLook;
    void Awake()
    {
        playerInput=new PlayerInput();
        onFoot=playerInput.OnFoot;
        playerMotor=GetComponent<PlayerMotor>();
        playerLook=GetComponent<PlayerLook>();
        onFoot.Jump.performed += ctx => playerMotor.Jump();
        OnEnable();
        onFoot.Sprint.performed += ctx => playerMotor.SprintPressed();
        onFoot.Sprint.canceled += ctx => playerMotor.SprintReleased();
    }

    

    private void FixedUpdate()
    {
        playerMotor.ProcessMove(onFoot.Movement.ReadValue<Vector2>());
    }
    private void LateUpdate()
    {
        playerLook.ProcessLook(onFoot.Look.ReadValue<Vector2>());
    }
    void Update()
    {
        
    }
    private void OnEnable()
    {
        onFoot.Enable();
    }
    private void OnDisable()
    {
        onFoot.Disable();
    }
}
