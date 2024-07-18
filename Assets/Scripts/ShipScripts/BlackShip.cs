using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackShip : MonoBehaviour
{
    private PlayerLives playerLives;   // Reference to the PlayerLives script
    public float movementTime = 60f;
    public bool isMoving = true;

    private void Start()
    {
        // Start the coroutine to move the ship down every 4 seconds
        StartCoroutine(MoveDownRoutine());

        // Find the PlayerLives script in the scene
        playerLives = GameObject.FindObjectOfType<PlayerLives>();
    }

    void Update()
    {
        movementTime -= Time.deltaTime;

        if (movementTime <= 0.0f)
        {
            MovementTimeEnded();
        }
    }

    // Coroutine to move the ship down every 4 seconds
    private IEnumerator MoveDownRoutine()
    {
        while (isMoving)
        {
            yield return new WaitForSeconds(EnemyMovement.waitForSeconds1);  // Wait for 4 seconds
            transform.position += new Vector3(0, -EnemyMovement.moveDistance1, 0);  // Move the ship down
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Boundary")
        {
            // Deduct one life from the player
            if (playerLives != null)
            {
                playerLives.DeductLife();
            }
        }
    }

    public void MovementTimeEnded()
    {
        isMoving = false;
    }
}
