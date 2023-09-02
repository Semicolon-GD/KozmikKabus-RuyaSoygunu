using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipForward : MonoBehaviour
{
    [SerializeField] private float hiz = 3.0f; // Geminin hýzýný ayarlayýn.

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        // Ýlerleme vektörünü hesaplayýn (örneðin, X ekseninde düz ilerleme).
        Vector3 ilerlemeVektoru = Vector3.right * hiz;

        // Gemiyi bu vektördeki hýzda sürekli olarak ilerletin.
        rb.velocity = ilerlemeVektoru;


       
    }
}
