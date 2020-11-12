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
        int levelUnlocked = PlayerPrefs.GetInt("levelUnlocked", 3);

        for (int i = 0; i < buttons.Length; i++)
        {
            if(i + 3 > levelUnlocked)
            {
                buttons[i].interactable = false;
            }
                
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
