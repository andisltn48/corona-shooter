using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogScript : MonoBehaviour
{
    
    public GameObject title1, title2, dialog1, dialog2, dialog3, dialog4, dialog5, myimage;
    public Sprite image1, image2;
    int i = 0;

    public void push()
    {
        i = i + 1;
        Debug.Log(i);
    }
    void Update()
    {
        if (i == 1)
        {
            title1.SetActive(false);
            dialog1.SetActive(false);
            title2.SetActive(true);
            dialog2.SetActive(true);
            myimage.GetComponent<Image>().sprite = image2;

        }
        else if (i == 2)
        {
            title1.SetActive(true);
            title2.SetActive(false);
            dialog1.SetActive(false);
            title2.SetActive(false);
            dialog3.SetActive(true);
            dialog2.SetActive(false);
            myimage.GetComponent<Image>().sprite = image1;
        }
        else if (i == 3)
        {
            title1.SetActive(true);
            dialog1.SetActive(false);
            dialog4.SetActive(true);
            dialog3.SetActive(false);
            myimage.GetComponent<Image>().sprite = image1;
        }
        else if (i == 4)
        {
            title1.SetActive(false);
            dialog4.SetActive(false);
            title2.SetActive(true);
            dialog5.SetActive(true);
            myimage.GetComponent<Image>().sprite = image2;
        }
        else if (i == 5)
        {
            SceneManager.LoadScene(4);
        }

    }

}
