using System;
using System.Collections;
using UnityEngine;

public class PlayerLives : MonoBehaviour
{
    public int lives = 5;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void DeductLife()
    {
        lives -= 1;
        if (lives <= 0)
        {
            // Handle game over logic here
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        string[] enemyTags = { "GrayShip", "GreenShip", "RedShip", "OrangeShip", "YellowShip", "BlackShip", "BlueShip", "VioletShip", "GoldShip", "DiamondShip" };

        if (Array.Exists(enemyTags, tag => tag == collision.gameObject.tag))
        {
            Destroy(collision.gameObject);
            DeductLife();
        }
    }
}