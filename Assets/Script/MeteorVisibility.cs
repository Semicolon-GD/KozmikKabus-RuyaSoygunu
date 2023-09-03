using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MeteorVisibility : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Uzay gemisi veya baþka bir etiket kullanabilirsiniz
        {
            // Debug.Log("Yeni sahne");
            // Büyük meteorun Collider'ý ile temas saðlandýðýnda yeni sahneye geçin
            //SceneManager.LoadScene(""); // Yeni sahnenin adýný belirtin
        }
    }
}
