using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Building : MonoBehaviour
{
    public Transform srLeft;
    public Transform srRight;
    public Transform srTop;
    public Transform srFront;
    public float interpolation1 = 0;
    public float interpolation2 = 0;
    Vector2 endVector = new Vector2(2,2);

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Poles());
        new WaitForSeconds(1);
        StartCoroutine(Fronts());
    }

    IEnumerator Poles()
    {
        while (interpolation1 < 1)
        {
            srLeft.localScale = Vector2.Lerp(Vector2.zero, endVector, interpolation1);
            srRight.localScale = Vector2.Lerp(Vector2.zero, endVector, interpolation1);
            interpolation1 += 0.01f;
            yield return null;
        }
    }

    IEnumerator Fronts()
    {
        while (interpolation2 < 1)
        {
            srTop.localScale = Vector2.Lerp(Vector2.zero, endVector, interpolation2);
            srFront.localScale = Vector2.Lerp(Vector2.zero, endVector, interpolation2);
            interpolation2 += 0.005f;
            yield return null;
        }
    }
}
