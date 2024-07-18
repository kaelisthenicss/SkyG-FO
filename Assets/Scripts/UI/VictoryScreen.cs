using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryScreen : MonoBehaviour
{
    public float victoryDelay = 3f;

    void Update()
    {
        victoryDelay -= Time.deltaTime;

        if (victoryDelay <= 0.0f)
        {
            DelayEnded();
        }
    }

    public void DelayEnded()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
