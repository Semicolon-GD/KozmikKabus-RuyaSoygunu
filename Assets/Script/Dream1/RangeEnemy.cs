using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangeEnemy : MonoBehaviour
{
  
    [SerializeField] Animator _animator;
    Transform _player;

    void Start()
    {
        _player = PlayerControl.instance.transform;
    }

    void Update()
    {
        transform.LookAt(_player.position);
    }
}
