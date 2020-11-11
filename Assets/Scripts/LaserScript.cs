using System.Collections;
using System.Collections.Generic;
using System.Security.Permissions;
using UnityEngine;

public class LaserScript : MonoBehaviour
{

    public GameObject ARCamera;
    public GameObject Smoke;

    public int GreenScore;
    public int RedScore;

    public void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(ARCamera.transform.position, ARCamera.transform.forward, out hit))
        {
            if (hit.transform.name == "GreenVirus" || hit.transform.name == "GreenVirus(Clone)")
            {
                ScoreText.scoreAmount += GreenScore;
                Debug.Log(ScoreText.scoreAmount);
                Destroy(hit.transform.gameObject);
                // Instantiate(Smoke, hit.point, Quaternion.LookRotation(hit.normal));
            }
            if (hit.transform.name == "RedVirus" || hit.transform.name == "RedVirus(Clone)")
            {
                ScoreText.scoreAmount += RedScore;
                Debug.Log(ScoreText.scoreAmount);
                Destroy(hit.transform.gameObject);
            }
        }
    }
}
