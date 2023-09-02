using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pass : MonoBehaviour
{
    public void StartScene(int sceneID)
    {

        SceneManager.LoadScene(0);
    }

    public void SettingScene(int sceneID)
    {

        SceneManager.LoadScene(2);
    }
}
