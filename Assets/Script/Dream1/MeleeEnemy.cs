using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeEnemy : MonoBehaviour
{
   
    [SerializeField] float _speed;
    [SerializeField] Animator _animator;
    Transform _player;

    private void Start()
    {
        _player = PlayerControl.instance.transform;
    }

    private void Update()
    {
        transform.LookAt(_player.position);
        if (Vector3.Distance(transform.position,_player.position)<=2f)
        {
            _animator.SetBool("Punch", true);
        }
        if (Vector3.Distance(transform.position, _player.position)  >= 2f)
        {
            transform.position = Vector3.MoveTowards(transform.position, _player.position, _speed * Time.deltaTime);
            _animator.SetBool("Punch", false);
        }
    }
}
