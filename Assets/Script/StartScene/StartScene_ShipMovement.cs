using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScene_ShipMovement : MonoBehaviour
{
    [SerializeField] GameObject _blackHole;
    [SerializeField] float _arrivalTime = 10f;

    Vector3 _blackHolePos;
    Vector3 _startPos;

    float _distance;
    float _timer;

    bool _keepMoving=true;
                     
    void Awake()
    {
        _startPos = transform.position;
        _blackHolePos = _blackHole.transform.position;
    }

    private void Start()
    {
        _distance = Vector3.Distance(_startPos, _blackHolePos);
    }

    private void FixedUpdate()
    {

        if (_keepMoving)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(_blackHolePos.x, transform.position.y, _blackHolePos.z), (_distance / _arrivalTime) * Time.deltaTime);
        }
        
       if(_keepMoving==false)
        { 
            _timer += Time.deltaTime;
            _blackHole.transform.localScale = Vector3.Lerp(new Vector3(100,100,100),new Vector3(550f,550f,550f),_timer/4);
        }
        if (_blackHole.transform.localScale==new Vector3(550f,550f,550f))
        {
            NextScene();
        }
    }

    private void NextScene()
    {
        SceneManager.LoadScene("SecondScene");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("BlackHole"))
        {
            _keepMoving = false;

        }
    }
  

}
