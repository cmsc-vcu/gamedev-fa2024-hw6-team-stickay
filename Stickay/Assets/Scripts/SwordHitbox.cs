using UnityEngine;

public class SwordHitbox : MonoBehaviour
{
    [SerializeField] private PlayerController playerController;  // Reference to the player controller
    [SerializeField] private LayerMask enemyLayer;  // Layer for enemies

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Sword hit something: " + other.gameObject.name);  // Log for anything the sword hits

        // Check if the object is on the enemy layer
        if (((1 << other.gameObject.layer) & enemyLayer) != 0)
        {
            Debug.Log("Enemy detected by sword hitbox");

            // Check if the player is pressing down while jumping (downward attack)
            if (Input.GetKey(KeyCode.DownArrow) && Input.GetButton("Jump"))
            {
                // Bounce off the enemy
                playerController.Bounce();
                Debug.Log("Bounced off enemy!");
                Destroy(other.gameObject);  // Destroy the enemy or apply damage logic
            }
            else
            {
                // Player collided without attacking, so they die
                playerController.Die();
                Debug.Log("Player died from enemy collision");
            }
        }
        else
        {
            Debug.Log("Not an enemy, no action taken.");
        }
    }
}
