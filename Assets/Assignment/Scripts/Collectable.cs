using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    protected static int score = 0;
    public GameObject collector;
    public string collectorTag;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision: " + collision.gameObject.tag + " Collector: " + collectorTag);
        if (collision.gameObject.tag == collectorTag)
        {
            score++;
            Debug.Log(score);
            Destroy(gameObject);
        }
    }
}
