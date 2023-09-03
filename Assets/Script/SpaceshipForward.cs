using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipForward : MonoBehaviour
{
    public float moveSpeed = 2.0f; // Hareket hýzý

    private Rigidbody rb;

    private void Start()
    {
        // Rigidbody bileþenini al
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // X ekseninde ilerleme vektörünü oluþtur
        Vector3 ilerlemeVektoru = -Vector3.right * moveSpeed;

        // Gemiyi bu vektördeki hýzda sürekli olarak ilerletin.
        rb.velocity = ilerlemeVektoru;
    }
}
