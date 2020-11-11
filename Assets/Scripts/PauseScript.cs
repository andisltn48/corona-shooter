using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class PauseScript : MonoBehaviour
{
    public GameObject PausePopup;
    bool IsPaused = false;

    public void PauseGame()
    {
        if (IsPaused)
        {
            Resume();
        }
        else
        {
            Pause();
        }
    }
    void Resume()
    {
        PausePopup.SetActive(false);
        Time.timeScale = 1f;
        IsPaused = false;
    }
    void Pause()
    {
        PausePopup.SetActive(true);
        Time.timeScale = 0f;
        IsPaused = true;
    }
}
