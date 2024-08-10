using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void StartGame()
    {
        SceneChange sceneController = FindObjectOfType<SceneChange>();
        sceneController.LoadSceneByName("GameMode");
    }

    public void MainMenu()
    {
        SceneChange sceneController = FindObjectOfType<SceneChange>();
        sceneController.LoadSceneByName("SampleScene");
    }
}
