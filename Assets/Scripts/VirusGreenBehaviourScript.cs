using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusGreenBehaviourScript : MonoBehaviour
{
    
    public float mScaleMax;
    public float mScaleMin;

    public float mOrbitMaxSpeed;
    private float mOrbitSpeed;

    private Transform mOrbitAnchor;
    private Vector3 mOrbitDirection;

    private Vector3 mVirusMaxScale;
    public float mGrowingSpeed;
    private bool mIsVirusScaled = false;
    void Start()
    {
        VirusSettings();
    }
    private void VirusSettings()
    {
        mOrbitAnchor = Camera.main.transform;

        float x = Random.Range(-1f, 1f);
        float y = Random.Range(-1f, 1f);
        float z = Random.Range(-1f, 1f);
        mOrbitDirection = new Vector3(x, y, z);

        mOrbitSpeed = Random.Range(10f, mOrbitMaxSpeed);

        float scale = Random.Range(mScaleMin, mScaleMax);
        mVirusMaxScale = new Vector3(scale, scale, scale);

        transform.localScale = Vector3.zero;
    }
    void Update()
    {
        RotateVirus();

        if (!mIsVirusScaled)
            ScaleObj();
    }
    private void RotateVirus()
    {
        transform.RotateAround(
            mOrbitAnchor.position, mOrbitDirection, mOrbitSpeed * Time.deltaTime);

        transform.Rotate(mOrbitDirection * 30 * Time.deltaTime);
    }
    private void ScaleObj()
    {
        if (transform.localScale != mVirusMaxScale)
            transform.localScale = Vector3.Lerp(transform.localScale, mVirusMaxScale, Time.deltaTime * mGrowingSpeed);
        else
            mIsVirusScaled = true;
    }
}
