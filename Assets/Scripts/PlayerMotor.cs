using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Interactions;

public class PlayerMotor : MonoBehaviour
{
    private CharacterController characterController;
    private Vector3 playerVelocity;
    public float walkSpeed,sprintSpeed;
    private float moveSpeed;
    private bool isGrounded;
    public bool sprinting = false;
    public float gravity = -9.8f;
    public float jumpHeight = 3f;
    
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        moveSpeed = walkSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded=characterController.isGrounded;
        
    }
    public void ProcessMove(Vector2 move)
    {
        Vector3 moveDirection = Vector3.zero;
        moveDirection.x = move.x;
        moveDirection.z = move.y;
        characterController.Move(transform.TransformDirection(moveDirection)* moveSpeed * Time.deltaTime);
        playerVelocity.y += gravity * Time.deltaTime;
        if (isGrounded &&playerVelocity.y<0)
        {
            playerVelocity.y = -2f;
        }
        characterController.Move(playerVelocity*Time.deltaTime);
        Debug.Log(playerVelocity.y);
        
    }
    public void SprintPressed()
    {
        if (isGrounded)
        {
            sprinting = true;
            moveSpeed = sprintSpeed;
        }
    }
    public void SprintReleased()
    {
        sprinting=false;
        moveSpeed = walkSpeed;
    }
    public void Jump()
    {
        if (isGrounded)
        {
            playerVelocity.y = Mathf.Sqrt(jumpHeight*-3.0f*gravity);
        }
    }
    
    
}
