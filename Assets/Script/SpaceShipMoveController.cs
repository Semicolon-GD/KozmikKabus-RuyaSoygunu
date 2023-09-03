using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipMoveController : MonoBehaviour
{
    //Bu kod yukarý aþagý sag sol için

    [SerializeField] private float hareketHizi = 5.0f;

    void Update()
    {
        float tusGecisi = Input.GetAxis("Horizontal");//x
        transform.Translate(tusGecisi * Time.deltaTime * hareketHizi, 0, 0);

        float tusGecisi1 = Input.GetAxis("Vertical");//y
        transform.Translate(0, tusGecisi1 * Time.deltaTime * hareketHizi, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Meteor")
        {
            Destroy(collision.gameObject);
        }
    }
}
