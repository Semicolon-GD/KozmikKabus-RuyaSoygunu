using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab; // Olu�turulacak d��man�n �nceden tan�mlanm�� prefab�
    public float spawnInterval = -5.0f; // D��manlar�n olu�turulma aral���
    public float spawnRadius = -10.0f; // D��manlar�n olu�turulaca�� rastgele alan�n yar� �ap�

    private float timeSinceLastSpawn = 0.0f;

    private void Update()
    {
        // Belirli bir aral�kta d��manlar� olu�turmak i�in zaman� takip edin
        timeSinceLastSpawn += Time.deltaTime;

        // Zaman spawnInterval'e ula�t���nda yeni bir d��man olu�turun
        if (timeSinceLastSpawn >= spawnInterval)
        {
            SpawnEnemy();
            timeSinceLastSpawn = 0.0f; // Zaman� s�f�rlay�n
        }
    }

    private void SpawnEnemy()
    {
        // Rastgele bir pozisyon olu�turun
        Vector3 randomPosition = Random.insideUnitSphere * spawnRadius;
        randomPosition += transform.position; // Spawner'�n pozisyonuna ekleyin

        // Yarat�c�y� bu pozisyonda olu�turun
        Instantiate(enemyPrefab, randomPosition, Quaternion.identity);
    }
}
