using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public static bool gameIsPaused = false;
    public GameObject pausemenuUI;
    public void Playgame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
    }

    public void MenuDisplay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);
    }
    /* public void playOne()
    {
        GameControl.noPlayers = 1;
        SceneManager.LoadScene("SampleScene");
    }
    public void playtwo()
    {
        GameControl.noPlayers = 2;
        SceneManager.LoadScene("SampleScene");
    } */
    public void gamequit()
    {
        Debug.Log("Quit!!!");
        Application.Quit();
    }
    public void resume()
    {
        pausemenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }
   void pause()
    {
        pausemenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }

     void Update()
    {
         if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPaused)
            {
                resume();
            } else
            {
                pause();
            }
        }
    }

}
