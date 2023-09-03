using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finishScript : MonoBehaviour
{
    

    private float delayInSeconds = 30f; // Sahne de�i�ikli�i gecikme s�resi

    private void Start()
    {
        // Belirledi�iniz s�re sonunda sahneyi de�i�tirin

        StartCoroutine(LoadNextScene());
        
        // Invoke("LoadNextScene", delayInSeconds);
    }

    IEnumerator LoadNextScene()
    {
        yield return new WaitForSeconds(delayInSeconds);
        SceneManager.LoadScene(4);
    }
}
