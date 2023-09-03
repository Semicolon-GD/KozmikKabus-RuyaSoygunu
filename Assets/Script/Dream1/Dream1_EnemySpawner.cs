using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class Dream1_EnemySpawner : MonoBehaviour
{
    public Transform player;
    [SerializeField] MeleeEnemy _meleePrefab;
    [SerializeField] RangeEnemy _rangePrefab;
    [SerializeField] GameObject _meleeParent;
    [SerializeField] GameObject _rangeParent;
    [SerializeField] Transform _spawnPosition1;
    

    ObjectPool<MeleeEnemy> _meleePool;
    ObjectPool<RangeEnemy> _rangePool;

    void Awake()
    {  
        _meleePool = new ObjectPool<MeleeEnemy>(CreateMelee, SpawnMeleeEnemy, MeleePutBackToPool, defaultCapacity:20);
        _rangePool = new ObjectPool<RangeEnemy>(CreateRange, SpawnRange, RangePutBackToPool, defaultCapacity: 10);
    }

    void RangePutBackToPool(RangeEnemy enemy)
    {
        enemy.gameObject.SetActive(false);
    }

    void SpawnRange(RangeEnemy enemy)
    {
        enemy.transform.position = _spawnPosition1.position;
        enemy.gameObject.SetActive(true);
    }

    RangeEnemy CreateRange()
    {
        var rangeEnemy = Instantiate(_rangePrefab, _rangeParent.transform, true);
        return rangeEnemy;
    }

    internal void MeleePutBackToPool(MeleeEnemy enemy)
    {
        enemy.gameObject.SetActive(false);
    }

    void SpawnMeleeEnemy(MeleeEnemy enemy)
    {
        enemy.transform.position = _spawnPosition1.position;
        enemy.gameObject.SetActive(true);
    }

    MeleeEnemy CreateMelee()
    {
       var meleeEnemy = Instantiate (_meleePrefab,_meleeParent.transform,true);
        return meleeEnemy;
    }

   
}
