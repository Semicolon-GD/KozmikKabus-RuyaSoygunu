using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dream1_SpawnController : MonoBehaviour
{
     List<GameObject> _spawnLocations=new List<GameObject>();
    [SerializeField] Transform _player;

    
    private void Start()
    {
        foreach (Transform item in gameObject.GetComponentInChildren<Transform>(true))
        {
            _spawnLocations.Add(item.gameObject);
            item.gameObject.SetActive(false);
        }
           
    }


    private void Update()
    {
        foreach (GameObject item in _spawnLocations)
        {
            float distance = Vector3.Distance(item.transform.position, _player.position);
            if (distance <50)
            {
                item.gameObject.SetActive(true);
            }
        }
       
    }
}
