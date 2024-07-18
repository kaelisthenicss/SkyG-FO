using System;
using System.Collections;
using UnityEngine;

public class PlayerLives : MonoBehaviour
{
    public GameObject gameOverScreen;
    public GameObject victoryScreen;
    public GameObject[] heart;
    public int lives = 3;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(lives <= 2)
        {
            heart[2].SetActive(false);
        }

        if(lives <= 1)
        {
            heart[1].SetActive(false);
        }
    }

    public void DeductLife()
    {
        lives -= 1;

        if (lives <= 0)
        {
            gameOverScreen.SetActive(true);
            Destroy(heart[0]);
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        string[] enemyTags = { "GrayShip", "GreenShip", "RedShip", "OrangeShip", "YellowShip", "BlackShip", "BlueShip", "VioletShip", "GoldShip", "DiamondShip" };
        string[] gemTag = {"Gem"};
        if (Array.Exists(enemyTags, tag => tag == collision.gameObject.tag))
        {
            Destroy(collision.gameObject);
            DeductLife();
        }
        if (Array.Exists(gemTag, tag => tag == collision.gameObject.tag))
        {
            Destroy(collision.gameObject);
            victoryScreen.SetActive(true);
        }
    }
}