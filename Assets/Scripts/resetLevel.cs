using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class resetLevel : MonoBehaviour
{

    public void set()
    {
        int scene = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene(scene);
    }
}
