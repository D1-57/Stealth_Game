using UnityEngine;

public class ParentWorld2 : MonoBehaviour
{
    // This method will be called by child colliders
    public void OnChildTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Make sure your player has the "Player" tag
        {
            Debug.Log($"Player entered a child collider: {name}");
            levelManager.instance.world2Isclear = false;
            // Do something (e.g., damage player, play sound, etc.)
        }
    }
    public void OnChildTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")) // Make sure your player has the "Player" tag
        {
            Debug.Log($"Player exited a child collider: {name}");
            levelManager.instance.world2Isclear = true;
            // Do something (e.g., damage player, play sound, etc.)
        }
    }
}