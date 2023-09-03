using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MeteorController : MonoBehaviour
{
    public Transform blackHole; // Kara deliði temsil eden nesnenin referansý

    public float meteorSpeed = 5f; // Meteorlarýn hýzý
    public float destructionDistance = 1f; // Meteorlarýn kara deliðe ne kadar yakýn olmasý gerektiðini belirleyen mesafe


    void Start()
    {
        blackHole = GameObject.Find("BlackHole").transform;
    }


    private void Update()
    {
        // Meteorlarýn kara deliðe doðru hareket etmesi
        Vector3 directionToBlackHole = blackHole.position - transform.position;
        transform.Translate(directionToBlackHole.normalized * meteorSpeed * Time.deltaTime);

        // Meteorlarýn kara deliðe ne kadar yakýn olduðunu kontrol etme
        float distanceToBlackHole = directionToBlackHole.magnitude;

        if (distanceToBlackHole < destructionDistance)
        {
            // Meteor, kara deliðe girdiðinde yok etme iþlemi
            Destroy(gameObject); // veya gameObject.SetActive(false); kullanarak devre dýþý býrakabilirsiniz
        }
    }



    private void OnCollisionEnter(Collision collision)
    {
        // Ýki nesne çarpýþtýðýnda bu kod çalýþýr.

        // Çarpýþma kontrolü için çarpýþma nesnelerini etiket veya baþka bir özellikle kontrol edebilirsiniz.
        if (collision.gameObject.CompareTag("StarShip") && collision.gameObject.CompareTag("BlackHole"))
        {
            // Sahneyi deðiþtir
            SceneManager.LoadScene("SecondScene");
        }

        
    }



}
