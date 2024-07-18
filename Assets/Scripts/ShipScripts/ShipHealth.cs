using UnityEngine;

public class ShipHealth : MonoBehaviour
{
    public int lives = 5;  // Number of lives

    public void TakeDamage(int damage)
    {
        lives -= damage;  // Decrease lives by the amount of damage

        if (lives <= 0)
        {
            Destroy(gameObject);  // Destroy the ship if no lives left
        }
    }
}