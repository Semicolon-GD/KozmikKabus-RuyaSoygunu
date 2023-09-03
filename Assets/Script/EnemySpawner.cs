using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab; // Oluþturulacak düþmanýn önceden tanýmlanmýþ prefabý
    public float spawnInterval = -5.0f; // Düþmanlarýn oluþturulma aralýðý
    public float spawnRadius = -10.0f; // Düþmanlarýn oluþturulacaðý rastgele alanýn yarý çapý

    private float timeSinceLastSpawn = 0.0f;

    private void Update()
    {
        // Belirli bir aralýkta düþmanlarý oluþturmak için zamaný takip edin
        timeSinceLastSpawn += Time.deltaTime;

        // Zaman spawnInterval'e ulaþtýðýnda yeni bir düþman oluþturun
        if (timeSinceLastSpawn >= spawnInterval)
        {
            SpawnEnemy();
            timeSinceLastSpawn = 0.0f; // Zamaný sýfýrlayýn
        }
    }

    private void SpawnEnemy()
    {
        // Rastgele bir pozisyon oluþturun
        Vector3 randomPosition = Random.insideUnitSphere * spawnRadius;
        randomPosition += transform.position; // Spawner'ýn pozisyonuna ekleyin

        // Yaratýcýyý bu pozisyonda oluþturun
        Instantiate(enemyPrefab, randomPosition, Quaternion.identity);
    }
}
