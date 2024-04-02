using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class ScoreCount : MonoBehaviour
{
    public TMPro.TextMeshProUGUI scoreCounter;

    // Update is called once per frame
    void Update()
    {
        scoreCounter.text = "Score: " + Collectable.totalScore;
    }
}
