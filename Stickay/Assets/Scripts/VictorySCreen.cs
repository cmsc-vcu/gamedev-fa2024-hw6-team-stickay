using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryScreen : MonoBehaviour
{
    [SerializeField] private GameObject victoryScreenUI; // Reference to the victory screen UI

    private void Start()
    {
        victoryScreenUI.SetActive(false);  // Ensure the victory screen is hidden at the start
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))  // Ensure it's the player touching the flag
        {
            Debug.Log("Player touched the flag");  // Debugging to check if trigger works
            ShowVictoryScreen();
        }
    }

    private void ShowVictoryScreen()
    {
        Debug.Log("Victory! Showing victory screen...");  // Debugging log for activating the screen
        Time.timeScale = 0f;  // Freeze the game
        victoryScreenUI.SetActive(true);  // Activate the victory screen UI
    }

    // Button action to restart the game
    public void RestartGame()
    {
        Debug.Log("Restarting game...");
        Time.timeScale = 1f;  // Unfreeze the game
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);  // Restart the scene
    }

    // Optional: Button action to quit the game
    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }
}
