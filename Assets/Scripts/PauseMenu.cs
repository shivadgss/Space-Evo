using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject optionsMenu;
    public GameObject controlsMenu;
    public bool isPaused = false;

    private void Start()
    {
        Debug.Log(isPaused);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!isPaused)
            {
                pauseMenu.SetActive(true);
                Time.timeScale = 0;
                isPaused = true;
                Debug.Log(isPaused);

            }

            else
            {
                isPaused = false;
                pauseMenu.SetActive(false);
                controlsMenu.SetActive(false);
                optionsMenu.SetActive(false);
                Time.timeScale = 1;
                Debug.Log(isPaused);
            }
        }

        
    }


    public void Quit()
    {
        //send to main menu
        Debug.Log("you quit");
        Application.Quit();
    }

    public void Controls()
    {
        pauseMenu.SetActive(false);
        optionsMenu.SetActive(false);
        controlsMenu.SetActive(true);
    }


    public void Options()
    {
        pauseMenu.SetActive(false);
        controlsMenu.SetActive(false);
        optionsMenu.SetActive(true);

    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }


    public void opBack()
    {
        optionsMenu.SetActive(false);
        pauseMenu.SetActive(true);
    }

    public void contBack()
    {
        controlsMenu.SetActive(false);
        pauseMenu.SetActive(true);
    }

    public void mainmen()
    {
        SceneManager.LoadScene(0);
    }

  
}
