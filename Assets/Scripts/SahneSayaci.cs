using UnityEngine;
using UnityEngine.SceneManagement;

public class SahneSayaci : MonoBehaviour
{
    public string nextSceneName; // Ge�mek istedi�iniz sahnenin ad�

    private float delayInSeconds = 7f; // Sahne de�i�ikli�i gecikme s�resi

    private void Start()
    {
        // Belirledi�iniz s�re sonunda sahneyi de�i�tirin
        Invoke("LoadNextScene", delayInSeconds);
    }

    private void LoadNextScene()
    {
        // Sahneyi de�i�tir
        SceneManager.LoadScene(3);
    }
}