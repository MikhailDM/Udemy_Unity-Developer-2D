using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

    //Загрузка следующей сцены
    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    //Загрузка первой сцены
    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);
    }

    //Выход из игры
    public void QuitGame()
    {
        Application.Quit();
    }
}
