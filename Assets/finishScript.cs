using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finishScript : MonoBehaviour
{
    

    private float delayInSeconds = 30f; // Sahne deðiþikliði gecikme süresi

    private void Start()
    {
        // Belirlediðiniz süre sonunda sahneyi deðiþtirin

        StartCoroutine(LoadNextScene());
        
        // Invoke("LoadNextScene", delayInSeconds);
    }

    IEnumerator LoadNextScene()
    {
        yield return new WaitForSeconds(delayInSeconds);
        SceneManager.LoadScene(4);
    }
}
