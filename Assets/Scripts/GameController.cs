using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject popup;
    int sceneIndex;

    void Start()
    {
        sceneIndex = SceneManager.GetActiveScene().buildIndex;   
    }

    public void SceneToLoad(int stage)
    {
        SceneManager.LoadScene(stage);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    public void OpenPopup()
    {
        popup.SetActive(true);
    }
    public void MissionDetails(GameObject details)
    {
        details.SetActive(!details.activeSelf);
    }
    public void replayGame()
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
