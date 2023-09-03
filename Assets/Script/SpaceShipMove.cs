using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipMove : MonoBehaviour
{
    //Bu kod z y�n�nde sabit h�zda hareket ettirmek i�in yani ileri dogru hareket i�in

    public float hareketHizi = 3.0f; // H�z� ayarlay�n
    private Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        // Z ekseninde ileri do�ru hareket ettirme
        Vector3 ileriHareket = transform.forward * hareketHizi * Time.deltaTime;
        rb.AddForce(ileriHareket);
    }


}
