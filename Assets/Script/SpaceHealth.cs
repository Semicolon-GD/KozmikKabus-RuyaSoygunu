using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpaceHealth : MonoBehaviour
{
    [SerializeField] private int can = 3; // Uzay gemisinin baþlangýç caný

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Meteor"))
        {
            // Asteroid ile çarpýþma durumunda caný azalt
            AzaltCan(1); // Ýstediðiniz kadar can azaltabilirsiniz
            Destroy(collision.gameObject);
        }
    }

    void AzaltCan(int miktar)
    {
        can -= miktar;

        if (can <= 0)
        {
            can = 0;
            SahneDegistir(1);
            // Oyunu sonlandýrmak için Application.Quit() 
            //Debug.Log("Öldün");
        }
    }

     void SahneDegistir(int sahneID)
    {
        SceneManager.LoadScene(1); // Belirlediðiniz sahneyi yükler
    }
}
