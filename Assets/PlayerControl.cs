using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public static PlayerControl instance;
    private void Awake()
    {
        if (instance == null)
            instance = this;
    }
}
