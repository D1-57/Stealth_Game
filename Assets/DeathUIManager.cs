using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathUIManager : MonoBehaviour
{
    public GameObject deathPanel;

    void Start()
    {
        if (deathPanel != null) deathPanel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void ShowDeathUI()
    {
        if (deathPanel != null) deathPanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void RetryLevel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GoToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }
}
