using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float moveSpeed = 5.0f; // D��man�n hareket h�z�
    private Transform player; // Oyuncunun pozisyonunu takip etmek i�in kullanaca��m�z transform

    private void Start()
    {
        // Oyuncunun Transform bile�enini bul
        player = GameObject.FindGameObjectWithTag("Player").transform;

        if (player == null)
        {
            Debug.LogError("Oyuncu (Player) nesnesi bulunamad�!");
        }
    }

    private void Update()
    {
        if (player == null)
        {
            return; // Oyuncu nesnesi yoksa, i�lem yapmay� durdur
        }

        // D��man� oyuncunun pozisyonuna do�ru hareket ettir
        Vector3 directionToPlayer = player.position - transform.position;
        transform.Translate(directionToPlayer.normalized * moveSpeed * Time.deltaTime);
    }
}
