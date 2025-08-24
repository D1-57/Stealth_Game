using UnityEngine;
using UnityEngine.SceneManagement;

public class WinningUIManager : MonoBehaviour
{
    public GameObject winningPanel;
    public GameObject nextButton;
    public GameObject playAgainButton;

    void Start()
    {
        if (winningPanel != null) winningPanel.SetActive(false);

        string levelName = SceneManager.GetActiveScene().name;
        if (levelName == "Level1")
        {
            if (nextButton != null) nextButton.SetActive(true);
            if (playAgainButton != null) playAgainButton.SetActive(false);
        }
        else if (levelName == "Level2")
        {
            if (nextButton != null) nextButton.SetActive(false);
            if (playAgainButton != null) playAgainButton.SetActive(true);
        }
    }

    public void ShowWinningUI()
    {
        Cursor.lockState = CursorLockMode.Confined;

        if (winningPanel != null) winningPanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void GoToLevel2()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level2");
    }

    public void GoToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }
}
