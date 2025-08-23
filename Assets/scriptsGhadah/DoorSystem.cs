using UnityEngine;

public class DoorSystem : MonoBehaviour
{
    public WinningUIManager winningUIManager;
    public DeathUIManager losingUIManager;
    public int correctDoorIndex = 0;

    public void OnDoorsActivated()
    {
        Debug.Log("Doors activated");
    }

    public void OnDoorEntered(int doorIndex)
    {
        if (doorIndex == correctDoorIndex)
        {
            if (winningUIManager != null) winningUIManager.ShowWinningUI();
        }
        else
        {
            if (losingUIManager != null) losingUIManager.ShowDeathUI();
        }
    }
}
