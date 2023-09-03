using UnityEngine;
using UnityEngine.SceneManagement;

public class SahneSayaci : MonoBehaviour
{
    public string nextSceneName; // Geçmek istediðiniz sahnenin adý

    private float delayInSeconds = 7f; // Sahne deðiþikliði gecikme süresi

    private void Start()
    {
        // Belirlediðiniz süre sonunda sahneyi deðiþtirin
        Invoke("LoadNextScene", delayInSeconds);
    }

    private void LoadNextScene()
    {
        // Sahneyi deðiþtir
        SceneManager.LoadScene(3);
    }
}