using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool gameHasEnded = false;
    public GameObject youdied;

    public void CompleteLevel() // code gets activated by end trigger script
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);  // loads next scene (build index + 1)
        Debug.Log("Level won!"); // check to see if code works in debug log
    }

    public void EndGame() // makes sure that the game can only end once
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER"); // check to see if code works in debug log
            youdied.SetActive(true);
            Invoke("Dead", 5f); // wait 5 seconds befor code dead starts
        }

    }

    void Dead() // you dead
    {
        SceneManager.LoadScene("Menu"); // load menu 
    }
}
