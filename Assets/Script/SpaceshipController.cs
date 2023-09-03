using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipController : MonoBehaviour
{
    [SerializeField] private float hareketHizi = 5.0f;

    void Update()
    {
        float tusGecisi = Input.GetAxis("Horizontal");//x
        transform.Translate(tusGecisi * Time.deltaTime * hareketHizi, 0, 0);

        float tusGecisi1 = Input.GetAxis("Vertical");//y
        transform.Translate(0, tusGecisi1 * Time.deltaTime * hareketHizi, 0);
    }
}
