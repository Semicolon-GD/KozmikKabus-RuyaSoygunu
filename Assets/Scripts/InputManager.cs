using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class InputManager : MonoBehaviour
{
    private PlayerInput playerInput;
    private PlayerInput.OnFootActions onFoot;
    private PlayerMotor playerMotor;
    void Awake()
    {
        playerInput=new PlayerInput();
        onFoot=playerInput.OnFoot;
        playerMotor=GetComponent<PlayerMotor>();
        onFoot.Jump.performed += ctx => playerMotor.Jump();
    }

    private void FixedUpdate()
    {
        playerMotor.ProcessMove(onFoot.Movement.ReadValue<Vector2>());
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
