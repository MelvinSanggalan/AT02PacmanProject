using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //Plays the game
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //Loads the next level.
    }


    //Quits the game
    public void QuitGame()
    {
        Application.Quit();
        print("Player has quit the game.");
    }

}
