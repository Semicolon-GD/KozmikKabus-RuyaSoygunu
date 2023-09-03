using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawner : MonoBehaviour
{
    //Meteorlarý belli yerlerden tekrardan çogaltmak amaç object pool

    public GameObject meteorPrefab;
    public MeteorObjectPool MeteorObjectPool;
    public float spawnTimer;
    public int size;
    private Camera mainCamera;
    






    private void Start()
    {
        MeteorObjectPool = new MeteorObjectPool(meteorPrefab, size);
        spawnTimer = Time.time;
        mainCamera = Camera.main;

       

    }

    private void Update()
    {
       


        if (Time.time > spawnTimer + 0.3f)
        {
            spawnTimer = Time.time;

            GameObject temp = MeteorObjectPool.Instance.GetObjectFromPool();
           
            temp.SetActive(true);
            //temp.transform.position = new Vector3(Random.Range(-130, 130), Random.Range(-130, 130), Random.Range(-130, 130));
            temp.transform.position = GenerateRandomPosition();

            StartCoroutine(DestroyMeteor(temp));
        }
    }

    private IEnumerator DestroyMeteor(GameObject _temp)
    {
        MeteorObjectPool.meteorObjectPool.Remove(_temp);
        yield return new WaitForSeconds(10f);
        if(_temp != null)
            MeteorObjectPool.Instance.ReturnObjectToPool(_temp);
    }

    private Vector3 GenerateRandomPosition()
    {

        //float randomX = Random.Range(-60,60);
        //float randomY = Random.Range(-60, 60);
        //float randomZ = Random.Range(0, 100);

        //Vector3 cameraPosition = mainCamera.transform.position;
        //Vector3 randomOffset = new Vector3(randomX, randomY, randomZ);

        //// Kameranýn pozisyonuna rastgele bir ofset uygula
        //Vector3 randomPosition = cameraPosition + randomOffset;

        //return randomPosition;


        float randomX = Random.Range(-60, 60);
        float randomY = Random.Range(-60, 60);
        float randomZ = Random.Range(100, 200); // Meteorlarýn uzay gemisinin dýþýnda oluþmasý için Z pozisyonunu artýrýn.

        Vector3 cameraPosition = mainCamera.transform.position;
        Vector3 randomOffset = new Vector3(randomX, randomY, randomZ);

        // Kameranýn pozisyonuna rastgele bir ofset uygula
        Vector3 randomPosition = cameraPosition + randomOffset;

        return randomPosition;
    }
    

}

