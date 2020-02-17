using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;//scene loading code
using UnityEngine.UI;//user interface code

public class MainMenuController : MonoBehaviour
{
    //load the scene with the name passed in
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    //close the application when called
    public void QuitGame()
    {
        Application.Quit();
    }
}