using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour
{
    private CharacterController characterController;
    private Vector3 playerVelocity;
    public float speed=5f;
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ProcessMove(Vector2 move)
    {
        Vector3 moveDirection = Vector3.zero;
        moveDirection.x = move.x;
        moveDirection.z = move.y;
        characterController.Move(transform.TransformDirection(moveDirection)*speed*Time.deltaTime);
    }
}
