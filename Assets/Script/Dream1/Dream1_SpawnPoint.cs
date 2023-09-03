using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Pool;

public class Dream1_SpawnPoint : MonoBehaviour
{
    [SerializeField] MeleeEnemy _meleePrefab;
    [SerializeField] RangeEnemy _rangePrefab;
    [SerializeField] int _meleeCount;
    [SerializeField] int _rangeCount;

    ObjectPool<MeleeEnemy> _meleePool;
    ObjectPool<RangeEnemy> _rangePool;

    Transform _player;





    void Awake()
    {
      
        _meleePool = new ObjectPool<MeleeEnemy>(CreateMelee, SpawnMeleeEnemy, MeleePutBackToPool, defaultCapacity: 20);
        _rangePool = new ObjectPool<RangeEnemy>(CreateRange, SpawnRange, RangePutBackToPool, defaultCapacity: 10);
    }
    
    

    void RangePutBackToPool(RangeEnemy enemy)
    {
        enemy.gameObject.SetActive(false);
    }

    void SpawnRange(RangeEnemy enemy)
    {
        float z = 0;
        if (transform.position.z < _player.position.z)
        {
            Debug.Log(transform.position.z + "  " + _player.position.z);
            z = Random.Range(-1, -6);
        }
        else if (transform.position.z > _player.position.z)
        {
            Debug.Log(transform.position.z + "  " + _player.position.z);
            z = Random.Range(1, 6);
        }
        float x = Random.Range(-4, +4);

        enemy.transform.position = new Vector3(transform.position.x - x, transform.position.y, transform.position.z - z);
        enemy.transform.rotation = transform.rotation;
        enemy.gameObject.SetActive(true);
    }

    RangeEnemy CreateRange()
    {
        var rangeEnemy = Instantiate(_rangePrefab, this.transform, true);
        return rangeEnemy;
    }

    internal void MeleePutBackToPool(MeleeEnemy enemy)
    {
        enemy.gameObject.SetActive(false);
    }

    void SpawnMeleeEnemy(MeleeEnemy enemy)
    {
        float z=0;
        if (transform.position.z>_player.position.z)
        {
            z = Random.Range(-1,-6);
        }
        else if (transform.position.z>_player.position.z)
        {
            z = Random.Range(1, 6);
        }
        float x = Random.Range(-4, +4);
        
        enemy.transform.position = new Vector3(transform.position.x-x,transform.position.y,transform.position.z-z);
        enemy.transform.rotation= transform.rotation;
        enemy.gameObject.SetActive(true);
    }

    MeleeEnemy CreateMelee()
    {
        var meleeEnemy = Instantiate(_meleePrefab, this.transform, true);
        return meleeEnemy;
    }

    void Start()
    {
        _player = PlayerControl.instance.transform;
        while (_meleeCount>0)
        {
            var enemy = _meleePool.Get();
            _meleeCount--;
        }
    
        while(_rangeCount>0)
        {
            var enemy = _rangePool.Get();
            _rangeCount--;
        }
    }
}
