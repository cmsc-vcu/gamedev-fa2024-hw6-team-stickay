using UnityEngine;
using UnityEngine.SceneManagement;  // For restarting the scene
using UnityEngine.UI;  // For handling UI elements

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;  // Singleton instance

    [SerializeField] GameObject deathScreenUI;  // Reference to the death screen UI canvas
    [SerializeField] Button restartButton;      // Reference to the Restart button

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        deathScreenUI.SetActive(false);  // Make sure the death screen is hidden at the start
        restartButton.onClick.AddListener(RestartGame);  // Attach the RestartGame function to the button
    }

    // Call this when the player dies
    public void TriggerDeathScreen()
    {
        Debug.Log("Player Died - Showing death screen");
        deathScreenUI.SetActive(true);  // Show the death screen
    }

    // Method to restart the game
    public void RestartGame()
    {
        Debug.Log("Restarting Game...");
        Time.timeScale = 1;  // Unpause the game if paused
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);  // Reload the current scene
    }
}
