using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    protected static int score = 0;
    public static int totalScore = 0;
    public string collectorTag;

    private void Update()
    {
        totalScore = score;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("Collision: " + collision.gameObject.tag + " Collector: " + collectorTag);
        if (collision.gameObject.tag == collectorTag)
        {
            score++;
            //Debug.Log(score);
            totalScore = score;
            Destroy(gameObject);
        }
    }

    public static void ResetScore()
    {
        score = 0;
        
    }
}
