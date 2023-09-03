using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PassScene : MonoBehaviour
{
    public void Basla(int sahenID)
    {
        SceneManager.LoadScene(0); // Belirlediðiniz sahneyi yükler
    }
    public void Yenile(int sahenID)
    {
        SceneManager.LoadScene(0); // Belirlediðiniz sahneyi yükler
    }

    public void Krediler(int sahenID)
    {
        SceneManager.LoadScene(2); // Belirlediðiniz sahneyi yükler
    }

    public void Cikis()
    {
        Application.Quit();
    }
}
