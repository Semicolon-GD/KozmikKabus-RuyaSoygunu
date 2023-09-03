using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpaceHealth : MonoBehaviour
{
    [SerializeField] private int can = 3; // Uzay gemisinin ba�lang�� can�

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Meteor"))
        {
            // Asteroid ile �arp��ma durumunda can� azalt
            AzaltCan(1); // �stedi�iniz kadar can azaltabilirsiniz
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
            // Oyunu sonland�rmak i�in Application.Quit() 
            //Debug.Log("�ld�n");
        }
    }

     void SahneDegistir(int sahneID)
    {
        SceneManager.LoadScene(1); // Belirledi�iniz sahneyi y�kler
    }
}
