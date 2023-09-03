using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipMoveController : MonoBehaviour
{
    //Bu kod yukarý aþagý sag sol için

    [SerializeField] private float hareketHizi = 5.0f;
    private Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontalInput, verticalInput,0 ) * hareketHizi * Time.deltaTime;
        rb.AddForce (movement);
        
    }

    
}
