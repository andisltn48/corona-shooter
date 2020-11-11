using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetLevel : MonoBehaviour
{
    public void set()
    {
        PlayerPrefs.DeleteAll();
    }
}
