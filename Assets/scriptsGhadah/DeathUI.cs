using UnityEngine;

public class DeathUI : MonoBehaviour
{
    public GameObject deathPanel;

    public void ShowDeath()
    {
        deathPanel.SetActive(true);
        Time.timeScale = 0f;
    }
}
