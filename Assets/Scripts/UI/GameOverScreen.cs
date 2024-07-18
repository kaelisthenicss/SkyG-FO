using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public GameObject gameOverScreen;
    public float gameOverDelay = 3f;

    void Update()
    {
        gameOverDelay -= Time.deltaTime;

        if (gameOverDelay <= 0.0f)
        {
            DelayEnded();
        }
    }

    public void DelayEnded()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
