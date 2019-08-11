using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame() // code for play button in menu
    {
        SceneManager.LoadScene("Level01"); // loads first QualityLevel from menu
    }


    public void QuitGame() // code for exit button in menu
    {
        Application.Quit(); // quits application
    }


}
