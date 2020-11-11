using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject popup;

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
}
