using UnityEngine;

public class WinUI : MonoBehaviour
{
    public GameObject winPanelLevel1;
    public GameObject winPanelLevel2;

    public void ShowWinLevel1()
    {
        winPanelLevel1.SetActive(true);
        Time.timeScale = 0f;
    }

    public void ShowWinLevel2()
    {
        winPanelLevel2.SetActive(true);
        Time.timeScale = 0f;
    }
}
