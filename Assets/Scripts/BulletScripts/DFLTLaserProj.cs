using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DFLTLaserProj : MonoBehaviour
{
    public float BulletSpeed = 80;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * BulletSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        string[] enemyTags = { "GrayShip", "GreenShip", "RedShip", "OrangeShip", "YellowShip", "BlackShip", "BlueShip", "VioletShip", "GoldShip", "DiamondShip" };

        if (Array.Exists(enemyTags, tag => tag == collision.gameObject.tag))
        {
            // Check if the enemy ship has a script that handles health
            var enemyShip = collision.gameObject.GetComponent<ShipHealth>();
            var bossShip = collision.gameObject.GetComponent<BlackHealth>();
            if (enemyShip != null)
            {
                enemyShip.TakeDamage(2);
                
            }
            else if (bossShip != null)
            {
                bossShip.TakeDamage(2);
            }
            else
            {
                Destroy(collision.gameObject);
            }

            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Boundary")
        {
            Destroy(gameObject);
        }
    }

}