using UnityEngine;

public class BadDoor : MonoBehaviour
{
    public GameObject losingUI;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            losingUI.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
