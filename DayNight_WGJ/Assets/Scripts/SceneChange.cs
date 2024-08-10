using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    // Método para carregar uma cena pelo nome
    public void LoadSceneByName(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }


    // Método para recarregar a cena atual
    public void ReloadCurrentScene()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);
    }

    // Método para sair do jogo (apenas para builds)
    public void QuitGame()
    {
        Application.Quit();
    }
}
