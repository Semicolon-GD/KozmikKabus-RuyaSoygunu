using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSelected : MonoBehaviour
{
    private int selectedWeapon;
    void Start()
    {
        
    }
    private void WeaponSelect()
    {
        int i = 0;
        foreach (Transform weapon in transform)
        {
            if (i == selectedWeapon)
            {
                weapon.gameObject.SetActive(true);
            }
            else
            {
                weapon.gameObject.SetActive(false);
            }
            i++;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
