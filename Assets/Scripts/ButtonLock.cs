using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonLock : MonoBehaviour
{
    public Button[] buttons;
    // Start is called before the first frame update
    void Start()
    {
        int levelUnlocked = PlayerPrefs.GetInt("levelUnlocked", 1);

        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].interactable = false;
        }
        for (int i = 0; i < levelUnlocked; i++)
        {
            buttons[i].interactable = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
