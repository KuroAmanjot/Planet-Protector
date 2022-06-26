using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool gameIsPause = false ;
   // public GameObject retryMenu; 
    public GameObject pauseMenuUI ;
    public isAliveHealth playerHealth;
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {

            if (gameIsPause)
            {
                Resume();

            }
            else
            {
                Pause(); 

            }
        }
        
    }

        public void Pause()
     {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPause = true; 

     }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameIsPause = false;
    }

    public void Exit()
    {
        Application.Quit();
        print("Quit"); 
    }

    public void MainMenu()
    {
        SceneManager.LoadScene( 0 );
        gameIsPause = false;
        Time.timeScale = 1f;
        playerHealth.retryMenu.SetActive(true);
    }

    public void RetryLevel()
    {
        SceneManager.LoadScene( 1 );
        gameIsPause = false;
        Time.timeScale = 1f;
        playerHealth.retryMenu.SetActive(true);
    }
}
