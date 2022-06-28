using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 


public class StartMenu : MonoBehaviour
{

   

    public void StartGame()
    {
        SceneManager.LoadScene(1);
        
    
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
