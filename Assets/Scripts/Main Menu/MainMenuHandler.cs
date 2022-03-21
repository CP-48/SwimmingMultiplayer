using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuHandler : MonoBehaviour
{
   public void playGame()
    {
        SceneManager.LoadScene("Main");
    }

    public void mainMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void quitGame()
    {
        Application.Quit();
        Debug.Log("Application Quit!");
        //UnityEditor.EditorApplication.isPlaying = false;
    }
}
