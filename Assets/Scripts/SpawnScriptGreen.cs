using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class SpawnScriptGreen : MonoBehaviour
{
    private bool SetPosition()
    {
        Transform cam = Camera.main.transform;
        transform.position = cam.forward * 20;
        return true;
    }
    public GameObject mVirusObj;

    public int mTotalVirus;
    public float mTimeToSpawn;
    private GameObject[] mVirus;

    private bool mPositionSet;
    private IEnumerator SpawnLoop()
    {
        StartCoroutine(ChangePosition());

        yield return new WaitForSeconds(0.2f);

        int i = 0;
        while (true)
        {
            mVirus[i] = SpawnElement();
            i++;
            yield return new WaitForSeconds(Random.Range(mTimeToSpawn, mTimeToSpawn * 3));
        }
    }
    private GameObject SpawnElement()
    {
        GameObject virus = Instantiate(mVirusObj, (Random.insideUnitSphere * 8 ) + transform.position, transform.rotation) as GameObject;
        float scale = Random.Range(0.5f, 1f);
        virus.transform.localScale = new Vector3(scale, scale, scale);
        return virus;
    }

    void Start()
    {
        StartCoroutine(SpawnLoop());
        mVirus = new GameObject[mTotalVirus];
    }
    private IEnumerator ChangePosition()
    {

        yield return new WaitForSeconds(0.2f);
        if (!mPositionSet)
        {
            if (VuforiaBehaviour.Instance.enabled)
                SetPosition();
        }
    }
}