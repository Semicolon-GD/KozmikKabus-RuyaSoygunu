using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MeteorController : MonoBehaviour
{
    public Transform blackHole; // Kara deli�i temsil eden nesnenin referans�

    public float meteorSpeed = 5f; // Meteorlar�n h�z�
    public float destructionDistance = 1f; // Meteorlar�n kara deli�e ne kadar yak�n olmas� gerekti�ini belirleyen mesafe


    void Start()
    {
        blackHole = GameObject.Find("BlackHole").transform;
    }


    private void Update()
    {
        // Meteorlar�n kara deli�e do�ru hareket etmesi
        Vector3 directionToBlackHole = blackHole.position - transform.position;
        transform.Translate(directionToBlackHole.normalized * meteorSpeed * Time.deltaTime);

        // Meteorlar�n kara deli�e ne kadar yak�n oldu�unu kontrol etme
        float distanceToBlackHole = directionToBlackHole.magnitude;

        if (distanceToBlackHole < destructionDistance)
        {
            // Meteor, kara deli�e girdi�inde yok etme i�lemi
            Destroy(gameObject); // veya gameObject.SetActive(false); kullanarak devre d��� b�rakabilirsiniz
        }
    }



    private void OnCollisionEnter(Collision collision)
    {
        // �ki nesne �arp��t���nda bu kod �al���r.

        // �arp��ma kontrol� i�in �arp��ma nesnelerini etiket veya ba�ka bir �zellikle kontrol edebilirsiniz.
        if (collision.gameObject.CompareTag("StarShip") && collision.gameObject.CompareTag("BlackHole"))
        {
            // Sahneyi de�i�tir
            SceneManager.LoadScene("SecondScene");
        }

        
    }



}
