using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MeteorVisibility : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Uzay gemisi veya ba�ka bir etiket kullanabilirsiniz
        {
            // Debug.Log("Yeni sahne");
            // B�y�k meteorun Collider'� ile temas sa�land���nda yeni sahneye ge�in
            //SceneManager.LoadScene(""); // Yeni sahnenin ad�n� belirtin
        }
    }
}
