using System.Collections;
using UnityEngine;

public class GreenShip : MonoBehaviour
{
    private PlayerLives playerLives;   // Reference to the PlayerLives script

    private void Start()
    {
        // Start the coroutine to move the ship down every 4 seconds
        StartCoroutine(MoveDownRoutine());

        // Find the PlayerLives script in the scene
        playerLives = GameObject.FindObjectOfType<PlayerLives>();
    }

    // Coroutine to move the ship down every 4 seconds
    private IEnumerator MoveDownRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(EnemyMovement.waitForSeconds1);  // Wait for 4 seconds
            transform.position += new Vector3(0, -EnemyMovement.moveDistance1, 0);  // Move the ship down
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Boundary")
        {
            // Destroy the ship
            Destroy(gameObject);

            // Deduct one life from the player
            if (playerLives != null)
            {
                playerLives.DeductLife();
            }
        }
    }
}