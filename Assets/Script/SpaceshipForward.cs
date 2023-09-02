using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipForward : MonoBehaviour
{
    [SerializeField] private float hiz = 3.0f; // Geminin h�z�n� ayarlay�n.

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        // �lerleme vekt�r�n� hesaplay�n (�rne�in, X ekseninde d�z ilerleme).
        Vector3 ilerlemeVektoru = Vector3.right * hiz;

        // Gemiyi bu vekt�rdeki h�zda s�rekli olarak ilerletin.
        rb.velocity = ilerlemeVektoru;


       
    }
}
