using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAfterConnection : MonoBehaviour
{
    public static bool isConnectionApproved = false;
    public GameObject connectionPanelUI;
    public GameObject GameCanvas;
    public GameObject MenuButton;

    // Update is called once per frame
    void Update()
    {
        if(connectionPanelUI.activeSelf)
        {
            if(isConnectionApproved == true)
            {
                StartGame();
                
            }

            else
            {
                Paused();
                
            }
        }
    }

    public void StartGame()
    {
        connectionPanelUI.SetActive(false);
        Time.timeScale = 1;
        isConnectionApproved = true;
        GameCanvas.SetActive(true);
    }

    public void Paused()
    {
        connectionPanelUI.SetActive(true);
        Time.timeScale = 0;
        isConnectionApproved = false;
        GameCanvas.SetActive(false);
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }
}
