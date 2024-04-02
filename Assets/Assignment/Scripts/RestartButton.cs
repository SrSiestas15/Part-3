using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class RestartButton : MonoBehaviour
{

    public void restart()
    {
        Collectable.ResetScore();
        SceneManager.LoadScene(0);
    }
}
