using System.Collections;
using UnityEngine;

public class RedShip : MonoBehaviour
{
    public float moveDistance = 0.8f;  // Distance to move down
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
            yield return new WaitForSeconds(7f);  // Wait for 4 seconds
            transform.position += new Vector3(0, -moveDistance, 0);  // Move the ship down
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