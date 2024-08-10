using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    // M�todo para carregar uma cena pelo nome
    public void LoadSceneByName(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }


    // M�todo para recarregar a cena atual
    public void ReloadCurrentScene()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);
    }

    // M�todo para sair do jogo (apenas para builds)
    public void QuitGame()
    {
        Application.Quit();
    }
}
