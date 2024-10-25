using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] float jumpForce = 10f;
    [SerializeField] float bounceForce = 12f;  // Bounce off enemies
    [SerializeField] LayerMask groundLayer;
    [SerializeField] LayerMask enemyLayer;  // For detecting enemies
    [SerializeField] Transform groundCheck;
    [SerializeField] float groundCheckRadius = 0.1f;
    [SerializeField] private GameObject deathScreenUI;
    [SerializeField] private Animator animator;  // Animator reference

    private Rigidbody2D rb;
    private bool isGrounded;
    private bool canJump = true;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        HandleMovement();
        HandleJump();
        HandleEnemyCollision();  // Check for enemy collision with groundCheck
        SetIdleState();  // Set the idle state based on movement
    }

    private void HandleMovement()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);
        
        // If player is moving, cancel idle animation
        if (Mathf.Abs(moveInput) > 0.1f)
        {
            animator.SetBool("isIdle", true);
        }
    }

    private void HandleJump()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);

        // Jump only if on ground and space is pressed
        if (Input.GetButtonDown("Jump") && isGrounded && canJump)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            animator.SetBool("isIdle", false);
            animator.SetBool("JumpTrigger", true);  // Play jump animation when space is pressed
            
        }
    }

    // Check if the groundCheck is colliding with the enemy
    private void HandleEnemyCollision()
    {
        Collider2D enemyCollider = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, enemyLayer);
        if (enemyCollider != null)
        {
            // If the player is not performing a downward attack with the sword
            if (!(Input.GetKey(KeyCode.DownArrow) && Input.GetButton("Jump")))
            {
                Die();  // Call Die() if the player collides without attacking
            }
        }
    }

    // Method to trigger bounce when hitting an enemy with the sword hitbox
    public void Bounce()
    {
        rb.velocity = new Vector2(rb.velocity.x, bounceForce);  // Apply bounce force
    }

    private void SetIdleState()
    {
        // If player is not moving, set idle to true
        if (Mathf.Abs(rb.velocity.x) < 0.1f && isGrounded)
        {
            animator.SetBool("isIdle", true);  // Activate idle animation
        }
    }

    private void OnDrawGizmosSelected()
    {
        // Visualize the groundCheck radius in the editor
        if (groundCheck != null)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(groundCheck.position, groundCheckRadius);
        }
    }

    // Handle player death and show death screen
    public void Die()
    {
        UnityEngine.Debug.Log("Player Died! Showing death screen...");

        // Ensure the UI is enabled
        if (deathScreenUI != null)
        {
            deathScreenUI.SetActive(true);  // Show death screen
            UnityEngine.Debug.Log("Death screen set to active");
        }
        else
        {
            UnityEngine.Debug.LogWarning("deathScreenUI is not assigned in the Inspector!");
        }

        // Freeze the game after showing the UI
        StartCoroutine(FreezeGameAfterDelay());
    }

    // Coroutine to freeze the game after death screen appears
    private IEnumerator FreezeGameAfterDelay()
    {
        yield return new WaitForSeconds(0.1f); // Small delay before freezing
        Time.timeScale = 0f; // Freeze the game
    }

    // Method to restart the game (called by the Restart button in the UI)
    public void RestartGame()
    {
        UnityEngine.Debug.Log("Restarting the game...");
        Time.timeScale = 1f;  // Unfreeze the game
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);  // Restart the current scene
    }
}
