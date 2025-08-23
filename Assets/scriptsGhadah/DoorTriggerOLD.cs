//using UnityEngine;

//public class DoorTriggerOLD : MonoBehaviour
//{
//    [Tooltip("If true -> WinningUI, otherwise -> LosingUI")]
//    public bool isCorrectDoor = false;

//    public GameObject losingUI;
//    public GameObject winningUI;

//    [Tooltip("Disable this collider after the first trigger to avoid retriggers")]
//    public bool disableAfterUse = true;

//    bool used = false;

//    private void OnTriggerEnter(Collider other)
//    {
//        if (used) return;
//        if (!other.CompareTag("Player")) return;

//        used = true;

//        var pm = other.GetComponent<playermove>();
//        if (pm != null) pm.enabled = false;

//        if (GameUIManager.instance != null)
//        {
//            if (isCorrectDoor) GameUIManager.instance.ShowWinningUI();
//            else GameUIManager.instance.ShowLosingUI();
//        }
//        else
//        {
//            Cursor.lockState = CursorLockMode.None;
//            Cursor.visible = true;
//            Time.timeScale = 0f;

//            if (isCorrectDoor && winningUI != null) winningUI.SetActive(true);
//            if (!isCorrectDoor && losingUI != null) losingUI.SetActive(true);
//        }

//        if (disableAfterUse)
//        {
//            var col = GetComponent<Collider>();
//            if (col != null) col.enabled = false;
//        }
//    }
//}
