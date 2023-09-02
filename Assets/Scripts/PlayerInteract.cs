using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    private Camera cam;
    [SerializeField]
    private float distance = 3f;
    [SerializeField]
    private LayerMask mask;
    void Start()
    {
        cam = GetComponent<PlayerLook>().cam;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
