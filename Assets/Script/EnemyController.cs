using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float moveSpeed = 5.0f; // Düþmanýn hareket hýzý
    private Transform player; // Oyuncunun pozisyonunu takip etmek için kullanacaðýmýz transform

    private void Start()
    {
        // Oyuncunun Transform bileþenini bul
        player = GameObject.FindGameObjectWithTag("Player").transform;

        if (player == null)
        {
            Debug.LogError("Oyuncu (Player) nesnesi bulunamadý!");
        }
    }

    private void Update()
    {
        if (player == null)
        {
            return; // Oyuncu nesnesi yoksa, iþlem yapmayý durdur
        }

        // Düþmaný oyuncunun pozisyonuna doðru hareket ettir
        Vector3 directionToPlayer = player.position - transform.position;
        transform.Translate(directionToPlayer.normalized * moveSpeed * Time.deltaTime);
    }
}
