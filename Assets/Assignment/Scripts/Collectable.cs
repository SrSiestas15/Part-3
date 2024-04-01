using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    protected static int score = 0;
    public GameObject collector;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision: " + collision.gameObject + " Collector: " + collector.gameObject);
        if (collision.gameObject == collector.gameObject)
        {
            score++;
            Debug.Log(score);
            Destroy(gameObject);
        }
    }
}
