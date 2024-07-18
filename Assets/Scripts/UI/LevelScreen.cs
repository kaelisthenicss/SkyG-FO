using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelScreen : MonoBehaviour
{
    public GameObject levelScreen;
    public float levelDelay = 3f;

    void Update()
    {
        levelDelay -= Time.deltaTime;

        if (levelDelay <= 0.0f)
        {
            DelayEnded();
        }
    }

    public void DelayEnded()
    {
        levelScreen.SetActive(false);
    }
}
