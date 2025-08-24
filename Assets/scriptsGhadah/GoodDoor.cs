using UnityEngine;

public class GoodDoor : MonoBehaviour
{
    public GameObject winningUI;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            winningUI.SetActive(true);
            Time.timeScale = 0f;

            Cursor.lockState = CursorLockMode.Confined;

        }
    }
}
