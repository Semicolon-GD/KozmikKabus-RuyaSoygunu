using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipForward : MonoBehaviour
{
    public float moveSpeed = 2.0f; // Hareket h�z�

    private Rigidbody rb;

    private void Start()
    {
        // Rigidbody bile�enini al
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // X ekseninde ilerleme vekt�r�n� olu�tur
        Vector3 ilerlemeVektoru = -Vector3.right * moveSpeed;

        // Gemiyi bu vekt�rdeki h�zda s�rekli olarak ilerletin.
        rb.velocity = ilerlemeVektoru;
    }
}
