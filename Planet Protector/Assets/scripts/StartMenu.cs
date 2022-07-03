using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 


public class StartMenu : MonoBehaviour
{
    private void Start()
    {
        AudioManager.soundsInstance.PlayMusic(1);
    }


    public void StartGame1()
    {
        SceneManager.LoadScene(1);
        
    
    }
    public void StartGame()
    {
        SceneManager.LoadScene(2);


    }

    public void SettingMenu()
    {

        //loading the setting scene 
    }

    public void ExitGame()
    {

        Application.Quit();
        print("quit"); 
    }




}
