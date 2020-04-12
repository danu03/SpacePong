using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HalamanManager : MonoBehaviour
{
    public bool isEscapeToExit;

    public GameObject PauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey (KeyCode.Escape))
        {
            if (isEscapeToExit)
            {
                Debug.Log("Exit");
                Application.Quit();
            }
            else
            {
                Pause();
            }
        }
        
    }

    private void Pause()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;

    }

    public void KeluarGame()
    {
        Application.Quit();
    }
    public void MulaiPermainan()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main");
    }
    public void KembaliKeMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
