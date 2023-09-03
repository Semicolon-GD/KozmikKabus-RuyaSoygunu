using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipMove : MonoBehaviour
{
    //Bu kod z yönünde sabit hýzda hareket ettirmek için yani ileri dogru hareket için

    public float hareketHizi = 3.0f; // Hýzý ayarlayýn
    private Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        // Z ekseninde ileri doðru hareket ettirme
        Vector3 ileriHareket = transform.forward * hareketHizi * Time.deltaTime;
        rb.AddForce(ileriHareket);
    }


}
