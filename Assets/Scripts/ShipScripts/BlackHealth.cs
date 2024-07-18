using UnityEngine;

public class BlackHealth : MonoBehaviour
{
    public int lives = 45;  // Number of lives
    public GameObject diamondGem;
    public Transform blackPosition;

    public void TakeDamage(int damage)
    {
        lives -= damage;  // Decrease lives by the amount of damage

        if (lives <= 0)
        {
            Instantiate(diamondGem, blackPosition.position, Quaternion.identity);
            Destroy(gameObject);  // Destroy the ship if no lives left
        }
    }
}
